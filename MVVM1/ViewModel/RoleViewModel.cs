using System.Collections.ObjectModel;
using MVVM1.Model;

namespace MVVM1.ViewModel
{
    public class RoleViewModel
    {
        public ObservableCollection<Role> ListRole { get; set; } = new ObservableCollection<Role>();

        public RoleViewModel()
        {
            this.ListRole.Add(new Role { Id = 1, NameRole = "Director" });
            this.ListRole.Add(new Role { Id = 2, NameRole = "Accountant" });
            this.ListRole.Add(new Role { Id = 3, NameRole = "Manager" });
        }
    }
}