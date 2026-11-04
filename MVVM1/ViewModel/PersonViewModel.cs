using System;
using System.Collections.ObjectModel;
using MVVM1.Model;

namespace MVVM1.ViewModel
{
    public class PersonViewModel
    {
        public ObservableCollection<Person> ListPerson { get; set; } = new ObservableCollection<Person>();

        public PersonViewModel()
        {
            this.ListPerson.Add(new Person { Id = 1, RoleId = 1, FirstName = "John", LastName = "Smith", Birthday = new DateTime(1980, 02, 28) });
            this.ListPerson.Add(new Person { Id = 2, RoleId = 2, FirstName = "Peter", LastName = "Petrov", Birthday = new DateTime(1981, 03, 20) });
            this.ListPerson.Add(new Person { Id = 3, RoleId = 3, FirstName = "Victor", LastName = "Viktorov", Birthday = new DateTime(1982, 04, 15) });
            this.ListPerson.Add(new Person { Id = 4, RoleId = 3, FirstName = "Sidor", LastName = "Sidorov", Birthday = new DateTime(1983, 05, 10) });
        }
    }
}