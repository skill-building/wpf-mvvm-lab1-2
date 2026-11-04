using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using MVVM1.Helper;
using MVVM1.Model;
using MVVM1.View;

namespace MVVM1.ViewModel
{
    public class RoleViewModel : INotifyPropertyChanged
    {
        private Role? selectedRole;
        public Role? SelectedRole
        {
            get => selectedRole;
            set { selectedRole = value; OnPropertyChanged(nameof(SelectedRole)); }
        }

        public ObservableCollection<Role> ListRole { get; set; } = new ObservableCollection<Role>();

        public RoleViewModel()
        {
            ListRole.Add(new Role { Id = 1, NameRole = "Director" });
            ListRole.Add(new Role { Id = 2, NameRole = "Accountant" });
            ListRole.Add(new Role { Id = 3, NameRole = "Manager" });
        }

        public int MaxId()
        {
            int max = 0;
            foreach (var r in ListRole) if (max < r.Id) max = r.Id;
            return max;
        }

        private RelayCommand? addRole;
        public RelayCommand AddRole =>
            addRole ??= new RelayCommand(_ =>
            {
                var wnRole = new WindowNewRole { Title = "New Role" };
                var role = new Role { Id = MaxId() + 1 };
                wnRole.DataContext = role;
                if (wnRole.ShowDialog() == true)
                    ListRole.Add(role);
                SelectedRole = role;
            });

        private RelayCommand? editRole;
        public RelayCommand EditRole =>
            editRole ??= new RelayCommand(_ =>
            {
                if (SelectedRole == null) return;
                var wnRole = new WindowNewRole { Title = "Edit Role" };
                var tempRole = new Role { Id = SelectedRole.Id, NameRole = SelectedRole.NameRole };
                wnRole.DataContext = tempRole;
                if (wnRole.ShowDialog() == true)
                    SelectedRole.NameRole = tempRole.NameRole;
            }, _ => SelectedRole != null && ListRole.Count > 0);

        private RelayCommand? deleteRole;
        public RelayCommand DeleteRole =>
            deleteRole ??= new RelayCommand(_ =>
            {
                if (SelectedRole == null) return;
                var result = MessageBox.Show(
                    $"Delete data for role: {SelectedRole.NameRole}",
                    "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                    ListRole.Remove(SelectedRole);
            }, _ => SelectedRole != null && ListRole.Count > 0);

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}