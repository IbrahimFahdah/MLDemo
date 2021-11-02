
namespace WinFormsApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCalc = new System.Windows.Forms.Button();
            this.txtCalcXc = new System.Windows.Forms.TextBox();
            this.txtMLXc = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLoadImg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalcYc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMLYc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCalc
            // 
            this.btCalc.Location = new System.Drawing.Point(267, 219);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(105, 24);
            this.btCalc.TabIndex = 0;
            this.btCalc.Text = "Calculate";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // txtCalcXc
            // 
            this.txtCalcXc.Location = new System.Drawing.Point(36, 29);
            this.txtCalcXc.Name = "txtCalcXc";
            this.txtCalcXc.ReadOnly = true;
            this.txtCalcXc.Size = new System.Drawing.Size(134, 23);
            this.txtCalcXc.TabIndex = 1;
            // 
            // txtMLXc
            // 
            this.txtMLXc.Location = new System.Drawing.Point(35, 26);
            this.txtMLXc.Name = "txtMLXc";
            this.txtMLXc.ReadOnly = true;
            this.txtMLXc.Size = new System.Drawing.Size(134, 23);
            this.txtMLXc.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btLoadImg
            // 
            this.btLoadImg.Location = new System.Drawing.Point(99, 220);
            this.btLoadImg.Name = "btLoadImg";
            this.btLoadImg.Size = new System.Drawing.Size(80, 24);
            this.btLoadImg.TabIndex = 0;
            this.btLoadImg.Text = "Load...";
            this.btLoadImg.UseVisualStyleBackColor = true;
            this.btLoadImg.Click += new System.EventHandler(this.LoadImg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCalcYc);
            this.groupBox1.Controls.Add(this.txtCalcXc);
            this.groupBox1.Location = new System.Drawing.Point(219, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Centroid (accurate value)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yc";
            // 
            // txtCalcYc
            // 
            this.txtCalcYc.Location = new System.Drawing.Point(36, 56);
            this.txtCalcYc.Name = "txtCalcYc";
            this.txtCalcYc.ReadOnly = true;
            this.txtCalcYc.Size = new System.Drawing.Size(134, 23);
            this.txtCalcYc.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMLYc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMLXc);
            this.groupBox2.Location = new System.Drawing.Point(220, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 79);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Centroid (ML predictd value)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Xc";
            // 
            // txtMLYc
            // 
            this.txtMLYc.Location = new System.Drawing.Point(35, 52);
            this.txtMLYc.Name = "txtMLYc";
            this.txtMLYc.ReadOnly = true;
            this.txtMLYc.Size = new System.Drawing.Size(134, 23);
            this.txtMLYc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(359, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Note: Image must be 100x100 px with only white and black colours";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(13, 220);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(80, 24);
            this.btClear.TabIndex = 0;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(220, 190);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(53, 15);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "Error (%)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 267);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btLoadImg);
            this.Controls.Add(this.btCalc);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ML Demo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.TextBox txtCalcXc;
        private System.Windows.Forms.TextBox txtMLXc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btLoadImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalcYc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMLYc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label lblError;
    }
}

