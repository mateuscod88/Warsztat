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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Warsztat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Dane logowania zaimplementuje się później. Teraz będzie śmigać na stałych.
        const string login = "zxc";
        const string haslo = "cxz";
       
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordPB.Password==haslo && LoginTB.Text==login)
            {
                MessageBox.Show("Nie rozumiem Twojej wizji.");
            }
            else
            {
                MessageBox.Show("Nie rozumiem Twojej wizji oraz Login lub hasło nie jest poprawne. ");
            }
        }


    }
}
