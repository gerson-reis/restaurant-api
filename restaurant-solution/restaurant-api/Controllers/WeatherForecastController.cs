using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurant.API;
using Restaurant.Domain;
using Restaurant.Repository.Interfaces;
using restaurant_domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurant_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IRepository<Plate> repository;
        private readonly IRepository<Client> repositoryClient;


        public WeatherForecastController(ILogger<WeatherForecastController> logger, IRepository<Plate> repository, IRepository<Client> repositoryClient)
        {
            _logger = logger;
            this.repository = repository;
            this.repositoryClient = repositoryClient;
        }

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //    //this.repository = repository;
        //}


        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            repositoryClient.InsertAsync(new Client("Gui", "895578")).Wait();

            var client = repositoryClient.GetById(1).Result;

            repositoryClient.DeleteAsync(client).Wait();

            var plate = new Plate("macarrão");
            repository.InsertAsync(plate).Wait();

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
