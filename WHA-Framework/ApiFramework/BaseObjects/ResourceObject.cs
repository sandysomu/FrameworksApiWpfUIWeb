using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiFramework.BaseObjects
{
    public class ResourceObject
    {

        internal async Task<HttpResponseMessage> GetVenuesList(string url)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("X-WHA-System-ID", "Swagger-Test");
            client.DefaultRequestHeaders.Add("X-WHA-Message-ID", "Message-ID-124");

            client.BaseAddress = new Uri(url);

            var response = await client.GetAsync("api/eventmanagement/v1/venues/12");
            return response;
        }

        public async Task<List<RootObjectModel>> GetVenuesList1(string url)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("X-WHA-System-ID", "Swagger-Test");
            client.DefaultRequestHeaders.Add("X-WHA-Message-ID", "Message-ID-124");

            client.BaseAddress = new Uri(url);

            var response =  await client.GetAsync("api/eventmanagement/v1/venues/12");
            var data = await response.Content.ReadAsAsync<List<RootObjectModel>>();
            return data;
        }




    }
}
