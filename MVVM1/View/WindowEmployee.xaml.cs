using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using MVVM1.Helper;
using MVVM1.Model;
using MVVM1.ViewModel;

namespace MVVM1.View
{
    public partial class WindowEmployee : Window
    {
        public WindowEmployee()
        {
            InitializeComponent();

            PersonViewModel vmPerson = new PersonViewModel();
            RoleViewModel vmRole = new RoleViewModel();
            List<Role> roles = new List<Role>();
            foreach (Role r in vmRole.ListRole)
                roles.Add(r);

            ObservableCollection<PersonDPO> persons = new ObservableCollection<PersonDPO>();
            foreach (var p in vmPerson.ListPerson)
            {
                FindRole finder = new FindRole(p.RoleId);
                Role rol = roles.Find(new Predicate<Role>(finder.RolePredicate));
                persons.Add(new PersonDPO
                {
                    Id = p.Id,
                    Role = rol.NameRole,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Birthday = p.Birthday
                });
            }
            lvEmployee.ItemsSource = persons;
        }
    }
}