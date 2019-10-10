using Newtonsoft.Json;
using Odev.Web.Clients.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace Odev.Web.Clients
{
    public class BaseClientManager<TEntity> : IBaseClientManager<TEntity> where TEntity : class
    {       
        private static string _baseUrl;
        static HttpClient _client;
        static string _url;

        public void Url(string baseUrl, string url)
        {
            _url = url;
            _baseUrl = baseUrl;
        }

        private void Client()
        {
            _client.BaseAddress = new Uri(_baseUrl);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity GetAll()
        {
            try
            {                
                using (_client = new HttpClient())
                {
                    Client();
                    var response = _client.GetAsync($"{_url}").Result;
                    response.EnsureSuccessStatusCode();
                    var result = response.Content.ReadAsAsync<TEntity>().Result;
                    return result;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(int id, TEntity entity)
        {
            throw new NotImplementedException();
        }

    }
}