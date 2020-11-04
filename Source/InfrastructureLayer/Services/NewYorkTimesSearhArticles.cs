using ApplicationLayer.Common;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Services
{
    public class NewYorkTimesSearhArticles : ISearch
    {

        private HttpClient client;
       
        public NewYorkTimesSearhArticles()
        {
            this.client = new HttpClient();                  
            this.client.DefaultRequestHeaders.Accept.Clear();
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public List<string> Search(string searchTerm)
        {           
            string requestUrl = $"https://api.nytimes.com/svc/search/v2/articlesearch.json?q={searchTerm}&api-key=SuhfzUg6IjWAxoTmg7glbiCLc7sb05hV";

            HttpResponseMessage response =  client.GetAsync(requestUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                var result =  response.Content.ReadAsAsync<NYTimesResult>().Result;

                List<string> resultList = new List<string>();
                List<NYTimesDoc> resultdocuments = new List<NYTimesDoc>(result.Response.Docs);
                foreach(var resultDoc in resultdocuments )
                {
                    resultList.Add(resultDoc.Headline.PrintHeadline);
                }

                return resultList;
            }
            return null;
        }

       
    }
}
