﻿using System;
using XabluApp1.Core.ViewModels;
using MvvmCross.iOS.Views;
using UIKit;

namespace XabluApp1.iOS.Views
{
    public partial class HomeViewController : BaseViewController<HomeViewModel>
    {
        public HomeViewController() : base("HomeViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

