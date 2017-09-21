using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XabluApp1.Core.Models
{
    public class Post
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Title { get; set; }
        public string Content { get; set; }
        public object Author { get; set; }
        public DateTime PublishedTime { get; set; }
        public int ReadTimes { get; set; }
        public string ImgUrl { get; set; } = "http://placeimg.com/640/480/any";

        
    }
}
