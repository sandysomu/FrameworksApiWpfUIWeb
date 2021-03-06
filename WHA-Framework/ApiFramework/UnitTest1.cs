using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ApiFramework.BaseObjects;
using Newtonsoft.Json;
using RestSharp;
using Xunit;


namespace ApiFramework
{
    public class UnitTest1
    {
        string url = "http://eventmanagement.uat.prod.sbet.com.au/";

        private ResourceObject resourceObject = new ResourceObject();
        [Fact]
        public async Task HttpClientGetTest()
        {

            var response = await resourceObject.GetVenuesList(url);

            response.EnsureSuccessStatusCode();

            var myRootObject = await response.Content.ReadAsAsync<RootObjectModel>();
        }

        


        [Fact]
        public async Task HttpClientPostTest()
        {
            string url = "http://eventmanagement.uat.prod.sbet.com.au/api/eventmanagement/v1/venues";


            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("X-WHA-System-ID", "Swagger-Test");
            client.DefaultRequestHeaders.Add("X-WHA-Message-ID", "Message-ID-124");


            var json = JsonConvert.SerializeObject(new
            {
                id = 0,
                eventType=1,
                country = "AUSTRALIA",
                name = "Test-Sandy",
                type = "C",
                state = "Australian Capital Territory"
            });


            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);


            response.EnsureSuccessStatusCode();




            // var response = await client.PostAsync(url, new StringContent(data));



            //string content = await response.Content.ReadAsStringAsync();
            // return await Task.Run(() = &gt; JsonObject.Parse(content));
        }

        [Fact]
        public void RestSharpTest()
        {

            var client = new RestClient(url);

            var request = new RestRequest("api/eventmanagement/v1/venues/12", Method.GET);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("X-WHA-System-ID", "Swagger-Test");
            request.AddHeader("X-WHA-Message-ID", "Message-ID-124");

            IRestResponse response = client.Execute(request);

            RootObjectModel root = JsonConvert.DeserializeObject<RootObjectModel>(response.Content);
        }

    }

    public class RootObjectModel
    {
        public int id { get; set; }
        public int eventType { get; set; }
        public string name { get; set; }
        
        public string country { get; set; }
        public string state { get; set; }
        public string type { get; set; }
        public int refId { get; set; }
    }
}
