using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Web.Http;
using System.Diagnostics.Contracts;
using socialconnectDATAAPI.Models;

namespace socialconnectDATAAPI.Controllers
{
    public class DataController : ApiController
    {
        //Testing API
        private List<DataClass> dataclass()
        {
            List<DataClass> result = new List<DataClass>();
            for (int i = 0; i < 10; i++)
            {
                result.Add(new DataClass()
                {
                    id = i + 1,
                    age = i + 18,
                    name = "VB" + i,
                    school = "GGC " + i
                });

            }
            return result;
        }
        //Routing and getting the result from DataClass from the MODEL
        [System.Web.Http.Route("api/DataClass")]
        public HttpResponseMessage Get()
        {
            Contract.Ensures(Contract.Result<HttpResponseMessage>() != null);
            var newData = dataclass();
            return Request.CreateResponse(HttpStatusCode.OK, new { StudentData = newData });

        }





    }
}
