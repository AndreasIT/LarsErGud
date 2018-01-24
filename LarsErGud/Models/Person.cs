using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarsErGud.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        public string FirstName { get { return firstName; } set { firstName = value; OnPropertyChanged(FullName); } }
        public string LastName { get { return lastName; } set { lastName = value; OnPropertyChanged(FullName); } }
        public string FullName { get { return FirstName + " " + LastName; } }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string PropertyName)

        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
