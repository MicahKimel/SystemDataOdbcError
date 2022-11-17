using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Threading.Tasks;

namespace SystemDataOdbcError.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public void Get()
        {
            {
                //THIS BREAKS HERE
                using (OdbcConnection connection = new OdbcConnection("ENTER ODBC CONNECTION HERE"))
                {
                    OdbcDataAdapter adapter = new OdbcDataAdapter("SELECT * FROM EMPLOYEE", connection);

                    try
                    {
                        connection.Open();
                        //do stuff

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
