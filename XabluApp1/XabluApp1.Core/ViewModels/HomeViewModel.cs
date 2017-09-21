using MvvmCross.Core.ViewModels;
using System.Collections.Generic;
using XabluApp1.Core.Models;
using XabluApp1.Core.Services;

namespace XabluApp1.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private int _age;

        public int Age
        {
            get => _age;
            set => SetProperty(ref _age, value);
        }


        private List<Post> _posts;

        public List<Post> Posts
        {
            get { return _posts; }
            set { SetProperty(ref _posts, value); }
        }

        private IWebService _webservice;

        public HomeViewModel(IWebService webService)
        {
            _webservice = webService;
        }

        public async void Init()
        {
            Posts = await _webservice.GetPosts();
        }
    }
}
