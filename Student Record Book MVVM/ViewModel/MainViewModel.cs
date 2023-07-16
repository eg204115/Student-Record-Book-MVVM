using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Student_Record_Book_MVVM.Commands;
using Student_Record_Book_MVVM.Models;
using Student_Record_Book_MVVM.View;

namespace Student_Record_Book_MVVM.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public ICommand ShowWindowCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand EditCommand { get; set; }



        public MainViewModel()
        {
            Users = UserManager.GetUsers();

            ShowWindowCommand = new Relaycommand(ShowWindow, CanShowWindow);
            DeleteCommand = new Relaycommand(DeleteUser, CanDeleteUser);

        }

        private bool CanDeleteUser(object obj)
        {
            // Add your logic to determine if a user can be deleted
            return true;
        }

        private void DeleteUser(object obj)
        {
            User selectedUser = obj as User;
            if (selectedUser != null)
            {
                Users.Remove(selectedUser);
            }
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            var mainwindow = obj as Window;

            AddUser addUserWin= new AddUser();
            addUserWin.Owner = mainwindow;
            addUserWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addUserWin.Show();
        }
    }
}
