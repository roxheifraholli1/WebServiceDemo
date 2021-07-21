using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace WebServiceDemo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        //Method 1 : Returns web service name and list of endpoints
        // GET: /info
        [HttpGet]
        [Route("/info")]
        public IEnumerable<string> Info()
        {
            return new string[] { "Info" };
        }


       
       
        

        //Method 2 : Reads XML DATA and Converts them to JSON 
        // POST /readXML
        [HttpGet]
        [Route("/readXML")]
        [Produces("application/json")]
        public string readXML()
        {
            string xml = @"<breakfast_menu>
                       <food>
                      <name>Belgian Waffles</name>
                      <price>$5.95</price>
                      <description>Two of our famous Belgian Waffles with plenty of real maple syrup</description>
                      <calories>650</calories>
                      </food>
                      <food>
                      <name>Strawberry Belgian Waffles</name>
                      <price>$7.95</price>
                      <description>Light Belgian waffles covered with strawberries and whipped cream</description>
                      <calories>900</calories>
                      </food>
                      </breakfast_menu>";


            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);


            string json = JsonConvert.SerializeXmlNode(doc);

             return json;
        }

        
    }
}
