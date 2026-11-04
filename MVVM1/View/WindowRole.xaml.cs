using System.Windows;
using MVVM1.ViewModel;

namespace MVVM1.View
{
    public partial class WindowRole : Window
    {
        public WindowRole()
        {
            InitializeComponent();
            DataContext = new RoleViewModel();
        }
    }
}