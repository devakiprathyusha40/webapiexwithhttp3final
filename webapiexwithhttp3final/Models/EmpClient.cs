using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;

namespace webapiexwithhttp3final.Models
{
  
    public class EmpClient
    {
        private string Base_URL = "https://localhost:44337/api/";
        public IEnumerable<Employee> FindAll()
        {
            //try
            //{
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("employees").Result;
                if (response.IsSuccessStatusCode)

                    return response.Content.ReadAsAsync<IEnumerable<Employee>>().Result;
                return null;
            //}
            //catch
            //{
            //    return null;
            //}
         
        }
    }
}