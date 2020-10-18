// <copyright file="WeatherForecastController.cs" company="DotnetCore3Templates">
// Copyright (c) 2020 DotnetCore3Templates. All rights reserved.
// </copyright>

namespace DotnetCore3Templates.StaticCodeAnalyzersSetup.Controllers
{
    using System;
    using System.Net;
    using DotnetCore3Templates.StaticCodeAnalyzersSetup.Contracts;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Weather forecast controller.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService weatherForecastService;
        private readonly ILogger<WeatherForecastController> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherForecastController"/> class.
        /// </summary>
        /// <param name="weatherForecastService">Instance of <see cref="IWeatherForecastService"/>.</param>
        /// <param name="logger">Logger.</param>
        public WeatherForecastController(IWeatherForecastService weatherForecastService, ILogger<WeatherForecastController> logger)
        {
            this.weatherForecastService = weatherForecastService ?? throw new ArgumentNullException(nameof(weatherForecastService));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Gets weather forecast for next 5 days.
        /// </summary>
        /// <returns>Array of forecast items for next 5 days.</returns>
        /// <response code="200">Returns evaluated items.</response>
        /// <response code="500">If something unexpected happened. See log for details.</response>
        [HttpGet]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Endpoint")]
        public IActionResult Get()
        {
            try
            {
                int numberOfDays = 5;
                var response = this.weatherForecastService.GetWeatherForecastForNextDays(numberOfDays);
                return this.Ok(response);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, ex.Message);
                return this.StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }
    }
}
