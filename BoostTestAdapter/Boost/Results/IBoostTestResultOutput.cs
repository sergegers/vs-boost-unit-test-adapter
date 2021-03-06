﻿// (C) Copyright ETAS 2015.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE_1_0.txt or copy at
// http://www.boost.org/LICENSE_1_0.txt)

using System;

namespace BoostTestAdapter.Boost.Results
{
    /// <summary>
    /// Interface for Boost Test result output.
    /// </summary>
    public interface IBoostTestResultOutput : IDisposable
    {
        /// <summary>
        /// Parses the referenced output and updates the referred to
        /// TestResultCollection with the newly collected information.
        /// </summary>
        /// <remarks>
        /// Implementations should check whether the collection already has an entry
        /// defined for a particular TestUnit and update the entry or rewrite as necessary.
        /// </remarks>
        /// <param name="collection">The TestResultCollection which will host the parsed details.</param>
        void Parse(TestResultCollection collection);
    }
}