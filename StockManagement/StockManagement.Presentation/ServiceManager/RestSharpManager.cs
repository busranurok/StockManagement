using System;
using RestSharp;

namespace StockManagement.Presentation.ServiceManager
{
    //static: hiçbir şekilde newlenmesin
    public static class RestSharpManager
    {
        static RestClient client = new RestClient("https://localhost:41802/api/");

        public static String SendGetRequest(string url)
        {
            RestRequest request = new RestRequest(url, Method.GET);

            var response = client.Execute(request);
            return response.Content;
        }

        public static String SendPostRequest(string jsonBody, string url)
        {
            RestRequest request = new RestRequest(url, Method.POST);
            request.AddJsonBody(jsonBody);

            var response = client.Execute(request);
            return response.Content;
        }
    }
}
