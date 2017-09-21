using MvvmCross.Core.ViewModels;

namespace XabluApp1.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public void ShowMenu()
        {
            ShowViewModel<MenuViewModel>();
        }
    }
}
