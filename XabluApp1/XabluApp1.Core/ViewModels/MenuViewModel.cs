using MvvmCross.Core.ViewModels;

namespace XabluApp1.Core.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public void Navigate<TViewModel>() where TViewModel : class, IMvxViewModel
        {
            ShowViewModel<TViewModel>();
        }
    }
}
