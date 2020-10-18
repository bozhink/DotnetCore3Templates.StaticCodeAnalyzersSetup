// <copyright file="WeatherForecast.cs" company="DotnetCore3Templates">
// Copyright (c) 2020 DotnetCore3Templates. All rights reserved.
// </copyright>

namespace DotnetCore3Templates.StaticCodeAnalyzersSetup
{
    using System;

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}