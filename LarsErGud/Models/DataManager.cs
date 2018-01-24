using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarsErGud.Models
{
    public class DataManager
    {
        public Person ImportantPerson { get; set; }
        
        public DataManager()
        {
            ImportantPerson = new Person { FirstName = "Anders", LastName = "And" };
        }

       
    }
}
