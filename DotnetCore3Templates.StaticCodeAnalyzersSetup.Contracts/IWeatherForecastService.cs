// <copyright file="IWeatherForecastService.cs" company="DotnetCore3Templates">
// Copyright (c) 2020 DotnetCore3Templates. All rights reserved.
// </copyright>

namespace DotnetCore3Templates.StaticCodeAnalyzersSetup.Contracts
{
    using System.Collections.Generic;
    using DotnetCore3Templates.StaticCodeAnalyzersSetup.Models;

    /// <summary>
    /// Weather forecast service.
    /// </summary>
    public interface IWeatherForecastService
    {
        /// <summary>
        /// Gets weather forecast for next days.
        /// </summary>
        /// <param name="numberOfDays">Number of days to evaluate weather forecast.</param>
        /// <returns>Evaluated weather forecast.</returns>
        IReadOnlyList<WeatherForecast> GetWeatherForecastForNextDays(int numberOfDays);
    }
}
