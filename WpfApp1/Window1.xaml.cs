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
using static WpfApp1.MainWindow;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public event CustomMessag cust;     //tworzymy sobie event i on będzie rozumieał  że przychodzi do niego delegat

        public Window1(CustomMessag _cust)
        {
            cust = _cust;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)                     
        {
            cust("jakies info z windows 2");            //i tutaj wywołujemy funckję a tamtej klasy - ona tam jest zdefiniowana i wywołuja się jako funckja tamtej klasy
        }
    }
}
