using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Data.OleDb;

namespace WebApi.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("DatosFoxPro")]
        public JsonResult Get()
        {
            
            //string cadena = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\omar.sanchez\\Downloads\\DBExamen; EXTENDED PROPERTIES=DBASE IV;";
            string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Extended Properties=dBASE IV;Data Source=C:\\Users\\omar.sanchez\\source\\repos\\WebApi\\data";
            //string cadena = @"Provider = VFPOLEDB; Data Source = C:\\data;Mode=ReadWrite|Share Deny None;Password="; 
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = cadena;
            string consulta = "SELECT * FROM tiposgtofilt";
            OleDbCommand command = new OleDbCommand(consulta, connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            
           
            return new JsonResult(new object());
        }
    }
}
