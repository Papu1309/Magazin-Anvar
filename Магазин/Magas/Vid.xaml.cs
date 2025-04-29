﻿using System;
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
                  new Spicok() {Name = "Родом из сердца",Price = 625,Foto = "/Photo/Родом из сердца.jpg" },
                  new Spicok() {Name = "Странный дом", Price = 689 ,Foto = "/Photo/Странный дом.jpg" },
                  new Spicok() {Name = "За спиной", Price = 759 ,Foto = "/Photo/За спиной.jpg" },
                  new Spicok() {Name = "Атомные привычки", Price = 899 ,Foto = "/Photo/Атомные привычки.jpg" },
                  new Spicok() {Name = "Татуировки менеджера", Price = 1115,Foto = "/Photo/Татуировки менеджера.jpg" },
                  new Spicok() {Name = "Пять языков любви", Price = 487 ,Foto = "/Photo/Пять языков любви.jpg" },
                  new Spicok() {Name = "Игры королей", Price = 781 ,Foto = "/Photo/Игры королей.jpg" },
                  new Spicok() {Name = "Записи юного врача", Price = 541 ,Foto = "/Photo/Записи юного врача.jpg" },
                  new Spicok() {Name = "Еженельник", Price = 428 ,Foto = "/Photo/Еженельник.jpg" },
                  new Spicok() {Name = "Двадцать шестой", Price = 587 ,Foto = "/Photo/Двадцать шестой.jpg" },
                  new Spicok() {Name = "Донецкое море", Price = 717 ,Foto = "/Photo/Донецкое море.jpg" },
                  new Spicok() {Name = "Пластиковый океан", Price = 1195,Foto = "/Photo/Пластиковый океан.jpg" },
                  new Spicok() {Name = "Клиника в Гоблинском переулке", Price = 505 ,Foto = "/Photo/Клиника в Гоблинском переулке.jpg" },
                  new Spicok() {Name = "Семнадцатый", Price = 1655,Foto = "/Photo/Семнадцатый.jpg" },
                
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
