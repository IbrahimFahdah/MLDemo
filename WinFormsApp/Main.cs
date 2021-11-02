using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MLBuild;

namespace WinFormsApp
{
    public partial class Main : Form
    {
        private string _fileName;
        private const double SquareSizeInPixel = 10.0;

        public Main()
        {
            InitializeComponent();
        }
        private void btCalc_Click(object sender, EventArgs e)
        {
            var inputX = new MLModel1.ModelInput();
            var inputY = new MLModel1.ModelInput();

            var myBitmap = new Bitmap(pictureBox1.Image, 100, 100);

            var sumX = 0.0;
            var sumY = 0.0;
            var area = 0.0;
            for (var x = 0; x < myBitmap.Width; x++)
            {
                for (var y = 0; y < myBitmap.Height; y++)
                {
                    // Get the color of a pixel within myBitmap.
                    var yb = (myBitmap.Height - 1) - y;
                    var pixelColor = myBitmap.GetPixel(x, y);
                    if (pixelColor.ToArgb() == Color.Black.ToArgb())
                    {
                        sumX += x;
                        sumY += yb;
                        area += 1;
                        UpdateCol(inputX, x, yb);
                        UpdateCol(inputY, yb, x);
                    }
                }
            }
            myBitmap.Dispose();

            // calculated centroid
            var xc = sumX / area;
            var yc = sumY / area;

            txtCalcXc.Text = $"{xc:0.000}";
            txtCalcYc.Text = $"{yc:0.000}";

            // ML predict centroid
            var scoreX = MLModel1.Predict(inputX).Score * SquareSizeInPixel;
            var scoreY = MLModel1.Predict(inputY).Score * SquareSizeInPixel;

            txtMLXc.Text = $"{scoreX:0.000}";
            txtMLYc.Text = $"{scoreY:0.000}";

            lblError.Text = $"Error(%): {Math.Max(100 * Math.Abs(scoreX - xc) / xc, 100 * Math.Abs(scoreY - yc) / yc):0.0}";
        }

        private void LoadImg_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            _fileName = openFileDialog1.FileName;
            LoadImg();
        }

        private void UpdateCol(MLModel1.ModelInput input, int x, int y)
        {
            var pixelArea = 0.01f;
            var col = (int)Math.Floor(x / SquareSizeInPixel);
            var row = (int)Math.Floor(y / SquareSizeInPixel);
            var pro = input.GetType().GetProperty($"Col{row}{col}", BindingFlags.Instance | BindingFlags.Public);
            pro.SetValue(input, (float)pro.GetValue(input) + pixelArea);
        }

        private void LoadImg()
        {
            var stream = new MemoryStream(File.ReadAllBytes(_fileName));
            pictureBox1.Image = Image.FromStream(stream);
        }

        #region drawing

        Point lastPoint = Point.Empty;
        Point firstPoint = Point.Empty;
        bool isMouseDown;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            isMouseDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {

                lastPoint = e.Location;

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (lastPoint != null)
            {
                if (pictureBox1.Image == null)
                {
                    Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = bmp;
                }

                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    var rec = new Rectangle(Math.Min(lastPoint.X, firstPoint.X),
                        Math.Min(lastPoint.Y, firstPoint.Y), Math.Abs(lastPoint.X - firstPoint.X),
                        Math.Abs(lastPoint.Y - firstPoint.Y));

                    g.DrawRectangle(new Pen(Color.Black, 2), rec);
                    g.FillRectangle(new SolidBrush(Color.Black), rec);
                }

                pictureBox1.Invalidate();
            }

            isMouseDown = false;
            lastPoint = Point.Empty;
            firstPoint = Point.Empty;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = null;
                Invalidate();
            }
        }

        #endregion
    }
}
