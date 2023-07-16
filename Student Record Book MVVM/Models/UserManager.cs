using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Student_Record_Book_MVVM.Models
{
    public class UserManager
    {
        public static ObservableCollection<User> _DatabaseUsers = new ObservableCollection<User>() {  
            new User { FirstName= "Nethmi",LastName= "Poornima",GPA= 3.75, BirthDay=new DateTime(2001, 1, 3), Email = "nethmi@gmail.com",Image = LoadImage("/Models/Images/4.png")},
            new User { FirstName = "Dasuni",LastName= "Nimesha",GPA= 3.90, BirthDay=new DateTime(2004, 7, 7), Email = "dasuni201@gmail.com" ,Image = LoadImage("/Models/Images/6.png") }, 
            new User { FirstName = "Imasha",LastName= "Sewmini", GPA= 3.85, BirthDay=new DateTime(2009, 1, 20),Email = "imashi222@gmail.com" , Image = LoadImage("/Models/Images/7.png")}, 
            new User { FirstName = "Nimal",LastName= "Rathnasiri",GPA= 3.55, BirthDay=new DateTime(1970, 1,14), Email = "nimalsiri@gmail.com",Image = LoadImage("/Models/Images/8.png") }, 
            new User { FirstName = "Damayanthi",LastName= "Liyanage",GPA= 3.65, BirthDay=new DateTime(1977, 4, 20), Email = "dammi77420@gmail.com" , Image = LoadImage("/Models/Images/9.png")} };
        private static BitmapImage LoadImage(string imagePath)
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(imagePath, UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            return bitmapImage;
        }

        public static ObservableCollection<User> GetUsers()
        {
            return _DatabaseUsers;
        }

        public static void AddUser(User user)
        {
            _DatabaseUsers.Add(user);
        }

        public static void RemoveUser(User user)
        {
            _DatabaseUsers.Remove(user);
        }
    }
}
