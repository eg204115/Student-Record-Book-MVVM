using Student_Record_Book_MVVM.Commands;
using Student_Record_Book_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Student_Record_Book_MVVM.ViewModel
{
    public class AddUserViewModel
    {
        public ICommand AddUserCommand { get; set; }

        
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDay { get; set; }
        public string? Email { get; set; }
        public double? GPA { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public AddUserViewModel()
        {
            AddUserCommand = new Relaycommand(AddUser, CanAddUser);
        }

        private bool CanAddUser(object obj)
        {
            return true;
        }

        private void AddUser(object obj)
        {
            UserManager.AddUser(new User() {FirstName = FirstName, LastName = LastName, Email =Email, BirthDay= BirthDay, GPA=GPA  });
        }
    }
}
