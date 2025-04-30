using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void CardNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Разрешаем только цифры
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
                return;
            }

            // Максимальная длина 16 символов
            if (textBox.Text.Length >= 16)
            {
                e.Handled = true;
            }
        }

        // Автоматическое добавление пробелов после каждых 4 цифр
        private void CardNumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string text = textBox.Text.Replace(" ", "");

            if (text.Length > 0 && text.Length % 4 == 0 && text.Length < 16)
            {
                textBox.Text = textBox.Text + " ";
                textBox.CaretIndex = textBox.Text.Length;
            }
        }

        // Валидация CVV (3-4 цифры)
        private void CVVTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Разрешаем только цифры
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
                return;
            }

            // Максимальная длина 4 символа
            if (textBox.Text.Length >= 4)
            {
                e.Handled = true;
            }
        }

        // Валидация имени держателя карты (только буквы и пробелы)
        private void CardHolderTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Разрешаем только буквы и пробелы
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Zа-яА-Я\s]+$"))
            {
                e.Handled = true;
            }
        }

        // Проверка всех полей перед оплатой
        private void PayButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = true;

            // Проверка номера карты (16 цифр без пробелов)
            string cardNumber = CartaNomer.Text.Replace(" ", "");
            if (cardNumber.Length != 16 || !long.TryParse(cardNumber, out _))
            {
                CartaNomer.Background = System.Windows.Media.Brushes.Pink;
                isValid = false;
            }
            else
            {
                CartaNomer.Background = System.Windows.Media.Brushes.White;
            }

            // Проверка CVV (3 или 4 цифры)
            if (CVG.Text.Length < 3 || CVG.Text.Length > 4 || !int.TryParse(CVG.Text, out _))
            {
                CVG.Background = System.Windows.Media.Brushes.Pink;
                isValid = false;
            }
            else
            {
                CVG.Background = System.Windows.Media.Brushes.White;
            }

            // Проверка имени держателя (минимум 2 слова)
            if (string.IsNullOrWhiteSpace(Name.Text) ||
                Name.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length != 1)
            {
                Name.Background = System.Windows.Media.Brushes.Pink;
                isValid = false;
            }
            else
            {
                Name.Background = System.Windows.Media.Brushes.White;
            }

            if (isValid)
            {
                MessageBox.Show("Оплата прошла успешно!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Пожалуйста, проверьте введенные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
