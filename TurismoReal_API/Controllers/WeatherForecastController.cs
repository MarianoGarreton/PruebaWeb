using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurismoReal_API.Utilidades;
using Oracle.ManagedDataAccess.Client;

namespace TurismoReal_API.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        /*public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }*/



        public IEnumerable<WeatherForecast> Get()
        {

            OracleCommand test = new OracleCommand();
            test.Connection = Conexion.AbrirConexion();

            OracleParameter glosa = (new OracleParameter
            {
                ParameterName = "out_glosa",
                Size = 80,
                Direction = System.Data.ParameterDirection.Output,
                OracleDbType = OracleDbType.Varchar2,

            });

            OracleParameter estado = (new OracleParameter
            {
                ParameterName = "out_estado",
                Size = 80,
                Direction = System.Data.ParameterDirection.Output,
                OracleDbType = OracleDbType.Decimal,

            });

            OracleParameter cursor = (new OracleParameter
            {
                ParameterName = "out_nombre_cursor",
                Direction = System.Data.ParameterDirection.Output,
                OracleDbType = OracleDbType.RefCursor,

            });

            //cmd.Parameters.AddRange(new[] { glosa, estado, cursor });

            test.CommandText = "EXEC sp_listar_usuario(15120220,:"+glosa+",:"+estado+",:"+cursor+");";
            OracleDataReader read = test.ExecuteReader();
            read.Read();
            

            WeatherForecast clima = new WeatherForecast();
            clima.Date = DateTime.Now;
            clima.TemperatureC = 10;
            clima.Summary = read.GetOracleString(4).ToString();

            List<WeatherForecast> datos = new List<WeatherForecast>();
            datos.Add(clima);

            return datos;
         
        }
    }
}