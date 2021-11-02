﻿// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML;
using Microsoft.ML.Trainers.FastTree;

namespace MLBuild
{
    public partial class MLModel1
    {
        public static ITransformer RetrainPipeline(MLContext context, IDataView trainData)
        {
            var pipeline = BuildPipeline(context);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.ReplaceMissingValues(new[] { new InputOutputColumnPair(@"col0", @"col0"), new InputOutputColumnPair(@"col1", @"col1"), new InputOutputColumnPair(@"col2", @"col2"), new InputOutputColumnPair(@"col3", @"col3"), new InputOutputColumnPair(@"col4", @"col4"), new InputOutputColumnPair(@"col5", @"col5"), new InputOutputColumnPair(@"col6", @"col6"), new InputOutputColumnPair(@"col7", @"col7"), new InputOutputColumnPair(@"col8", @"col8"), new InputOutputColumnPair(@"col9", @"col9"), new InputOutputColumnPair(@"col10", @"col10"), new InputOutputColumnPair(@"col11", @"col11"), new InputOutputColumnPair(@"col12", @"col12"), new InputOutputColumnPair(@"col13", @"col13"), new InputOutputColumnPair(@"col14", @"col14"), new InputOutputColumnPair(@"col15", @"col15"), new InputOutputColumnPair(@"col16", @"col16"), new InputOutputColumnPair(@"col17", @"col17"), new InputOutputColumnPair(@"col18", @"col18"), new InputOutputColumnPair(@"col19", @"col19"), new InputOutputColumnPair(@"col20", @"col20"), new InputOutputColumnPair(@"col21", @"col21"), new InputOutputColumnPair(@"col22", @"col22"), new InputOutputColumnPair(@"col23", @"col23"), new InputOutputColumnPair(@"col24", @"col24"), new InputOutputColumnPair(@"col25", @"col25"), new InputOutputColumnPair(@"col26", @"col26"), new InputOutputColumnPair(@"col27", @"col27"), new InputOutputColumnPair(@"col28", @"col28"), new InputOutputColumnPair(@"col29", @"col29"), new InputOutputColumnPair(@"col30", @"col30"), new InputOutputColumnPair(@"col31", @"col31"), new InputOutputColumnPair(@"col32", @"col32"), new InputOutputColumnPair(@"col33", @"col33"), new InputOutputColumnPair(@"col34", @"col34"), new InputOutputColumnPair(@"col35", @"col35"), new InputOutputColumnPair(@"col36", @"col36"), new InputOutputColumnPair(@"col37", @"col37"), new InputOutputColumnPair(@"col38", @"col38"), new InputOutputColumnPair(@"col39", @"col39"), new InputOutputColumnPair(@"col40", @"col40"), new InputOutputColumnPair(@"col41", @"col41"), new InputOutputColumnPair(@"col42", @"col42"), new InputOutputColumnPair(@"col43", @"col43"), new InputOutputColumnPair(@"col44", @"col44"), new InputOutputColumnPair(@"col45", @"col45"), new InputOutputColumnPair(@"col46", @"col46"), new InputOutputColumnPair(@"col47", @"col47"), new InputOutputColumnPair(@"col48", @"col48"), new InputOutputColumnPair(@"col49", @"col49"), new InputOutputColumnPair(@"col50", @"col50"), new InputOutputColumnPair(@"col51", @"col51"), new InputOutputColumnPair(@"col52", @"col52"), new InputOutputColumnPair(@"col53", @"col53"), new InputOutputColumnPair(@"col54", @"col54"), new InputOutputColumnPair(@"col55", @"col55"), new InputOutputColumnPair(@"col56", @"col56"), new InputOutputColumnPair(@"col57", @"col57"), new InputOutputColumnPair(@"col58", @"col58"), new InputOutputColumnPair(@"col59", @"col59"), new InputOutputColumnPair(@"col60", @"col60"), new InputOutputColumnPair(@"col61", @"col61"), new InputOutputColumnPair(@"col62", @"col62"), new InputOutputColumnPair(@"col63", @"col63"), new InputOutputColumnPair(@"col64", @"col64"), new InputOutputColumnPair(@"col65", @"col65"), new InputOutputColumnPair(@"col66", @"col66"), new InputOutputColumnPair(@"col67", @"col67"), new InputOutputColumnPair(@"col68", @"col68"), new InputOutputColumnPair(@"col69", @"col69"), new InputOutputColumnPair(@"col70", @"col70"), new InputOutputColumnPair(@"col71", @"col71"), new InputOutputColumnPair(@"col72", @"col72"), new InputOutputColumnPair(@"col73", @"col73"), new InputOutputColumnPair(@"col74", @"col74"), new InputOutputColumnPair(@"col75", @"col75"), new InputOutputColumnPair(@"col76", @"col76"), new InputOutputColumnPair(@"col77", @"col77"), new InputOutputColumnPair(@"col78", @"col78"), new InputOutputColumnPair(@"col79", @"col79"), new InputOutputColumnPair(@"col80", @"col80"), new InputOutputColumnPair(@"col81", @"col81"), new InputOutputColumnPair(@"col82", @"col82"), new InputOutputColumnPair(@"col83", @"col83"), new InputOutputColumnPair(@"col84", @"col84"), new InputOutputColumnPair(@"col85", @"col85"), new InputOutputColumnPair(@"col86", @"col86"), new InputOutputColumnPair(@"col87", @"col87"), new InputOutputColumnPair(@"col88", @"col88"), new InputOutputColumnPair(@"col89", @"col89"), new InputOutputColumnPair(@"col90", @"col90"), new InputOutputColumnPair(@"col91", @"col91"), new InputOutputColumnPair(@"col92", @"col92"), new InputOutputColumnPair(@"col93", @"col93"), new InputOutputColumnPair(@"col94", @"col94"), new InputOutputColumnPair(@"col95", @"col95"), new InputOutputColumnPair(@"col96", @"col96"), new InputOutputColumnPair(@"col97", @"col97"), new InputOutputColumnPair(@"col98", @"col98"), new InputOutputColumnPair(@"col99", @"col99") })
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new[] { @"col0", @"col1", @"col2", @"col3", @"col4", @"col5", @"col6", @"col7", @"col8", @"col9", @"col10", @"col11", @"col12", @"col13", @"col14", @"col15", @"col16", @"col17", @"col18", @"col19", @"col20", @"col21", @"col22", @"col23", @"col24", @"col25", @"col26", @"col27", @"col28", @"col29", @"col30", @"col31", @"col32", @"col33", @"col34", @"col35", @"col36", @"col37", @"col38", @"col39", @"col40", @"col41", @"col42", @"col43", @"col44", @"col45", @"col46", @"col47", @"col48", @"col49", @"col50", @"col51", @"col52", @"col53", @"col54", @"col55", @"col56", @"col57", @"col58", @"col59", @"col60", @"col61", @"col62", @"col63", @"col64", @"col65", @"col66", @"col67", @"col68", @"col69", @"col70", @"col71", @"col72", @"col73", @"col74", @"col75", @"col76", @"col77", @"col78", @"col79", @"col80", @"col81", @"col82", @"col83", @"col84", @"col85", @"col86", @"col87", @"col88", @"col89", @"col90", @"col91", @"col92", @"col93", @"col94", @"col95", @"col96", @"col97", @"col98", @"col99" }))
                                    .Append(mlContext.Regression.Trainers.FastTree(new FastTreeRegressionTrainer.Options() { NumberOfLeaves = 32768, MinimumExampleCountPerLeaf = 39, NumberOfTrees = 32768, MaximumBinCountPerFeature = 1024, LearningRate = 2.68734798564197E-07F, FeatureFraction = 0.01F, LabelColumnName = @"col100", FeatureColumnName = @"Features" }));

            return pipeline;
        }
    }
}