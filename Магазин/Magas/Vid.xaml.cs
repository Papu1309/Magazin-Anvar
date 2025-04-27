using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
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
using System.IO;
using Магазин.Datagrid;
using Microsoft.Win32;



namespace Магазин.Magas
{
    /// <summary>
    /// Логика взаимодействия для Vid.xaml
    /// </summary>
    public partial class aa : Page
    {
        //public BindingList<Spicok> Spicokk;
        public List<Spicok> Spicoks { get; set; }
        public aa()
        {
            InitializeComponent();
            LoadSpicoks();
            SpicokListWiew.ItemsSource = Spicoks;

        }
        public void LoadSpicoks()
        {
            Spicoks = new List<Spicok>
            {
                  new Spicok() {Name = "Антисептик",Price = 560,Foto = "/Photo/antiseptic.jpg",Opisanie = "Каждый рассказ открывает перед нами удивительный мир, в котором любовь и доброта занимают центральное место. Эти трогательные истории не только погружают нас в атмосферу тепла и заботы, но и демонстрируют крепкую, неразрывную связь между людьми и их четвероногими друзьями"},
                  new Spicok() {Name = "Ароматизатор", Price = 784,Foto = "/Photo/aromatizator.jpg" },
                  new Spicok() {Name = "Авточехлы", Price = 1700,Foto = "/Photo/avtochehli.jpg" },
                  new Spicok() {Name = "Чехол", Price = 300,Foto = "/Photo/chehol.jpg" },
                  new Spicok() {Name = "Игрушка", Price = 1790,Foto = "/Photo/igrushka.jpg" },
                  new Spicok() {Name = "Колпаки", Price = 3700,Foto = "/Photo/kolpaki.jpg" },
                  new Spicok() {Name = "Носки", Price = 680,Foto = "/Photo/noski.jpg" },
                  new Spicok() {Name = "Планшет", Price = 5800,Foto = "/Photo/planshet.jpg" },
                  new Spicok() {Name = "Порошок", Price = 1600,Foto = "/Photo/poroshok.jpg" },
                  new Spicok() {Name = "Телефон", Price = 11399,Foto = "/Photo/telephone.jpg" },
                  new Spicok() {Name = "Чайник", Price = 1349,Foto = "/Photo/chainic.jpg" },
                  new Spicok() {Name = "Тарелка", Price = 239,Foto = "/Photo/tarelka.jpg" },
                  new Spicok() {Name = "Крушка", Price = 149,Foto = "/Photo/krushka.jpg" },
                  new Spicok() {Name = "Лошка", Price = 59,Foto = "/Photo/loshka.jpg" },
                  new Spicok() {Name = "Вилка", Price = 59,Foto = "/Photo/Wilka.png" },
                  new Spicok() {Name = "Лошка", Price = 59,Foto = "/Photo/loshka.jpg" },
                  new Spicok() {Name = "Бутилированная вода", Price = 200,Foto = "/Photo/Woda.png" },
                  new Spicok() {Name = "Зарядка", Price = 400,Foto = "/Photo/zaradka.jpg" },
                  new Spicok() {Name = "Наушник", Price = 4567,Foto = "/Photo/nauchh.png" },
                  new Spicok() {Name = "Постельный комплект", Price = 2389,Foto = "/Photo/postkomplekt.jpg" },
                 
            };

        }
        public void Korzina_Click(object sender, RoutedEventArgs e)
        {
            List<Spicok> selectedSpicoks = new List<Spicok>();

            foreach (var Spicok in Spicoks)
            {
                if (Spicok.IsSelected)
                {
                    selectedSpicoks.Add(Spicok);
                }
            }
            Corzina corzina = new Corzina(selectedSpicoks);
            //this.Content = corzina;
            corzina.Show();
        }

        private void SpicokListWiew_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Opisanie_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Opisanie());
        }

    }
}
