// <copyright file="IApplicationContext.cs" company="DotnetCore3Templates">
// Copyright (c) 2020 DotnetCore3Templates. All rights reserved.
// </copyright>

namespace DotnetCore3Templates.StaticCodeAnalyzersSetup.Contracts
{
    using System;

    /// <summary>
    /// Application context.
    /// </summary>
    public interface IApplicationContext
    {
        /// <summary>
        /// Gets the <see cref="DateTime"/> provider.
        /// </summary>
        Func<DateTime> DateTimeProvider { get; }
    }
}
