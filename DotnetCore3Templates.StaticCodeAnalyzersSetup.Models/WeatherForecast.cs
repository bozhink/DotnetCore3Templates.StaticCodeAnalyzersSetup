// <copyright file="WeatherForecast.cs" company="DotnetCore3Templates">
// Copyright (c) 2020 DotnetCore3Templates. All rights reserved.
// </copyright>

namespace DotnetCore3Templates.StaticCodeAnalyzersSetup.Models
{
    using System;

    /// <summary>
    /// Weather forecast model.
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Gets or sets the date for the weather forecast.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the temperature in degrees Celsius.
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Gets the temperature in degrees Fahrenheit.
        /// </summary>
        public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);

        /// <summary>
        /// Gets or sets description summary for the weather forecast.
        /// </summary>
        public string Summary { get; set; }
    }
}
