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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Class1 class1 = new Class1();
            bool d = new bool();
            bool d1 = new bool();
            if (DL.Text!="" && SHR.Text!="")
            {
       d = class1.A(DL.Text,SHR.Text);
            }
            else
            {
          d1 = class1.B(DL.Text, SHR.Text); 
            }
            
             
            
            if (d1 == true)
            {
                MessageBox.Show("Все поля должны быть заполнены");

            }
           else if (d==false)
            {
                MessageBox.Show("Значения не должны быть отрицательными");

            }
           
            else if (d == true)
            {
                double S = Convert.ToDouble(DL.Text) * Convert.ToDouble(SHR.Text);
                MessageBox.Show("S="+S.ToString());

            }
            
        }
    }
}
