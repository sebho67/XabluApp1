using ModernHttpClient;
using MvvmCross.Platform;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XabluApp1.Core.Models;

namespace XabluApp1.Core.Services
{
    public interface IWebService
    {
        Task<List<Post>> GetPosts();
        Task<Post> GetPost(string id);
        Task<bool> EditPost(string id, Post post);
    }

    public class WebService : IWebService
    {
        private HttpClient _httpclient;

        public WebService()
        {
            _httpclient = new HttpClient(new NativeMessageHandler())
            {
                BaseAddress = new Uri("http://formation-cityformation.azurewebsites.Net/ws/")
            };
        }
        public async Task<bool> EditPost(string id, Post post)
        {
            var jpost = JsonConvert.SerializeObject(post);
            var ret = await _httpclient.PutAsync("Api/" + id, new StringContent(jpost));

            return ret.IsSuccessStatusCode;
        }

        public async Task<Post> GetPost(string id)
        {
            var json = await _httpclient.GetStringAsync($"Api/{id}");
            var post = JsonConvert.DeserializeObject<Post>(json);
            return post;
        }

        public async Task<List<Post>> GetPosts()
        {
            var json = await _httpclient.GetStringAsync("Api");
            Mvx.Error(_httpclient.BaseAddress.ToString());
            var posts = JsonConvert.DeserializeObject<List<Post>>(json);
            return posts;
        }
    }
}
