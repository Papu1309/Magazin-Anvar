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


namespace Магазин.Magas
{
    /// <summary>
    /// Логика взаимодействия для Doelen.xaml
    /// </summary>
    public partial class Doelen : Page
    {
        public Doelen()
        {
            InitializeComponent();
        }

        private void btnCarculate_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow nw = new NavigationWindow();
            nw.Content = new SpasiboZaOplatu();
            nw.ShowDialog();
        }
    }
}
