using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace MedusaWeb.Controllers
{
    public class ValuesController : ApiController
    {
        //// GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        public string Get()
        {
            try
            {
                var folder = Environment.GetFolderPath(System.Environment.SpecialFolder.CommonApplicationData);
                var filePath = Path.Combine(folder, "medusa.json");
                return System.IO.File.ReadAllText(filePath);
            }
            catch (Exception)
            {
                return null;
            }
        }

        // POST api/values
        public void Post([FromBody]FunctionGroup value)
        {
            var folder = Environment.GetFolderPath(System.Environment.SpecialFolder.CommonApplicationData);
            var filePath = Path.Combine(folder, "medusa.json");

            System.IO.File.WriteAllText(filePath, JsonConvert.SerializeObject(value));
        }

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
