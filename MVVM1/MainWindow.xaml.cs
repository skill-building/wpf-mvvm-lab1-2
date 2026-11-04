using System.Windows;
using MVVM1.View;

namespace MVVM1
{
    public partial class MainWindow : Window
    {
        public MainWindow() { InitializeComponent(); }

        private void Employee_OnClick(object sender, RoutedEventArgs e)
        {
            WindowEmployee wEmployee = new WindowEmployee();
            wEmployee.Show();
        }

        private void Role_OnClick(object sender, RoutedEventArgs e)
        {
            WindowRole wRole = new WindowRole();
            wRole.Show();
        }
    }
}