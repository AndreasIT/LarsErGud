using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarsErGud.View_model
{
    class Controller
    {
        public Models.DataManager DM { get; set; }
        public Controller()
        {
            DM = new Models.DataManager();
        }
        
    //    public string GetStartupFirstName()
    //    {
    //        string name = "";
    //        name = dm.ImportantPerson.FirstName;
    //        return name;
    //    }
    //    public string GetStartupLastName()
    //    {
    //        string name = "";
    //        name = dm.ImportantPerson.LastName;
    //        return name;
    //    }
    //    public string GetStartupFullName()
    //    {
    //        string name = "";
    //        name = dm.ImportantPerson.FullName;
    //        return name;
    //    }
    //    public void UpdatePerson(string firstName, string lastName)
    //    {
    //        dm.ImportantPerson.FirstName = firstName;
    //        dm.ImportantPerson.LastName = lastName;
    //    }
    }
}
