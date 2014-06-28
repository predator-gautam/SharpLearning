﻿using SharpLearning.CrossValidation.Shufflers;
using System;

namespace SharpLearning.CrossValidation
{
    /// <summary>
    /// Random cross validation uses a random shuffle of the observation indices to avoid any ordering issues.
    /// </summary>
    /// <typeparam name="TOut"></typeparam>
    public class RandomCrossValidation<TOut, TTarget> : CrossValidation<TOut, TTarget>
    {
        /// <summary>
        /// Cross validation for evaluating how learning algorithms generalise on new data
        /// </summary>
        /// <param name="modelLearner">The func should provide a learning algorithm 
        /// that returns a model predicting multiple observations</param>
        /// <param name="crossValidationFolds">Number of folds that should be used for cross validation</param>
        public RandomCrossValidation(CrossValidationLearner<TOut, TTarget> modelLearner, int crossValidationFolds)
            : base(modelLearner, new RandomCrossValidationShuffler<TTarget>(DateTime.Now.Millisecond), crossValidationFolds)
        {
        }

        /// <summary>
        /// Cross validation for evaluating how learning algorithms generalise on new data
        /// </summary>
        /// <param name="modelLearner">The func should provide a learning algorithm 
        /// that returns a model predicting multiple observations</param>
        /// <param name="crossValidationFolds">Number of folds that should be used for cross validation</param>
        /// <param name="seed"></param>
        public RandomCrossValidation(CrossValidationLearner<TOut, TTarget> modelLearner, int crossValidationFolds, int seed)
            : base(modelLearner, new RandomCrossValidationShuffler<TTarget>(seed), crossValidationFolds)
        {
        }
    }
}
