using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Student_Record_Book_MVVM.Models
{
    public class User
    {
        public User()
        {

        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDay { get; set; }
        public string? Email { get; set; }
        public double? GPA { get; set; }
        public string? FullName { get; set; }
        public string ImagePath { get; set; }
        public BitmapImage Image { get; set; }


        public User(int age, string firstName, string lastName, DateTime dateOfBirth, BitmapImage image, double gpa)
        {

            FirstName = firstName;
            LastName = lastName;
            BirthDay = dateOfBirth;
            Image = image;
            GPA = gpa;
        }
        private BitmapImage LoadImage(string imagePath)
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(imagePath, UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            return bitmapImage;
        }

    }
}
