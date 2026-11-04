using System.Windows;

namespace MVVM1.View
{
    public partial class WindowNewRole : Window
    {
        public WindowNewRole() { InitializeComponent(); }
        private void Save_Click(object sender, RoutedEventArgs e) => DialogResult = true;
    }
}