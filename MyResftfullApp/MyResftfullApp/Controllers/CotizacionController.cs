using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using Newtonsoft;
using Newtonsoft.Json;

namespace MyResftfullApp.Controllers
{
    interface ICotizacionStrategy
    {
        string Moneda();
    }


    public class CotizacionController : ApiController
    {
        // GET: api/cotizacion/peso
        [Route("api/cotizacion/{moneda}")]
        [ResponseType(typeof(string))]
        public IHttpActionResult GetCotizacion(string moneda)
        {
            switch (moneda.ToLower())
            {
                case "dolar":
                    return Ok(new Dolar().Moneda());
                case "peso":
                    return Ok(new Peso().Moneda());
                case "real":
                    return Ok(new Real().Moneda());
            }
            return Ok();
        }
    }

    public class Dolar : ICotizacionStrategy
    {
        public string Moneda()
        {
            var url = "https://www.bancoprovincia.com.ar/Principal/Dolar";
            return new WebClient().DownloadString(url);
        }
    }

    public class Peso : ICotizacionStrategy
    {
        public string Moneda()
        {
            throw new HttpException(401, "Auth Failed");
        }
    }

    public class Real : ICotizacionStrategy
    {
        public string Moneda()
        {
            throw new HttpException(401, "Auth Failed");
        }
    }
}
