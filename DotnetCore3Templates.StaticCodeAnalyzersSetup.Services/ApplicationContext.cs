// <copyright file="ApplicationContext.cs" company="DotnetCore3Templates">
// Copyright (c) 2020 DotnetCore3Templates. All rights reserved.
// </copyright>

namespace DotnetCore3Templates.StaticCodeAnalyzersSetup.Services
{
    using System;
    using DotnetCore3Templates.StaticCodeAnalyzersSetup.Contracts;

    /// <summary>
    /// Application context.
    /// </summary>
    public class ApplicationContext : IApplicationContext
    {
        /// <inheritdoc/>
        public Func<DateTime> DateTimeProvider { get; } = () => DateTime.Now;
    }
}
