using LarsErGud.View_model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LarsErGud.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Controller controller = new Controller();
        public MainWindow()
        {
            InitializeComponent();
           // SetTextBoxes();
            DataContext = new Controller();
        }

        //private void Button_Save_Click(object sender, RoutedEventArgs e)
        //{
        //    string firstName = TextBox_FirstName.Text;
        //    string lastName = Textbox_LastName.Text;
           // controller.UpdatePerson(firstName, lastName);
           // SetTextBoxes();
        //}
        //private void SetTextBoxes()
        //{
        //    TextBox_FirstName.Text = controller.GetStartupFirstName();
        //    Textbox_LastName.Text = controller.GetStartupLastName();
        //    TextBlock_FullName.Text = controller.GetStartupFullName();
        //}
    }

}
