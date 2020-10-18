// <copyright file="WeatherForecastService.cs" company="DotnetCore3Templates">
// Copyright (c) 2020 DotnetCore3Templates. All rights reserved.
// </copyright>

namespace DotnetCore3Templates.StaticCodeAnalyzersSetup.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DotnetCore3Templates.StaticCodeAnalyzersSetup.Contracts;
    using DotnetCore3Templates.StaticCodeAnalyzersSetup.Models;

    /// <summary>
    /// Weather forecast service.
    /// </summary>
    public class WeatherForecastService : IWeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing",
            "Bracing",
            "Chilly",
            "Cool",
            "Mild",
            "Warm",
            "Balmy",
            "Hot",
            "Sweltering",
            "Scorching",
        };

        private readonly IApplicationContext applicationContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherForecastService"/> class.
        /// </summary>
        /// <param name="applicationContext">Instance of <see cref="IApplicationContext"/>.</param>
        public WeatherForecastService(IApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext ?? throw new ArgumentNullException(nameof(applicationContext));
        }

        /// <inheritdoc/>
        public IReadOnlyList<WeatherForecast> GetWeatherForecastForNextDays(int numberOfDays)
        {
            var now = this.applicationContext.DateTimeProvider.Invoke();
            var rng = new Random();
            return Enumerable.Range(1, numberOfDays).Select(index => new WeatherForecast
            {
                Date = now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)],
            })
            .ToArray();
        }
    }
}
