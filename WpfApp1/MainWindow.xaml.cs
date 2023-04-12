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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
  

      

         
    
        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
            }

            private void btn_Click(object sender, RoutedEventArgs e)
            {
                Button clickedButton = sender as Button;
                Random rnd = new Random();
                int rastgeleSayi = rnd.Next(1, 6);
                MessageBox.Show($"{clickedButton.Name} butonuna tıklandı. Rastgele sayı: {rastgeleSayi}");
            }
        }
    }










                 

