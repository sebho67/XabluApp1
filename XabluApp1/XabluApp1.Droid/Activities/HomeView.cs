using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;
using MvvmCross.Binding.BindingContext;
using XabluApp1.Core.ViewModels;

namespace XabluApp1.Droid.Activities
{
    [Activity(Label = "HomeView")]
    public class HomeView : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            var homeaxml = FindViewById<View>(Resource.Id.home);
            var monage = FindViewById<TextView>(Resource.Id.monAge);
            var bindings = this.CreateBindingSet<HomeView, HomeViewModel>();
            bindings.Bind(monage).TwoWay().To(viewmodel => viewmodel.Age);
            bindings.Apply();


            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}