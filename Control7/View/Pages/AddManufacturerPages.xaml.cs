using Control7.Model;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Control7.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddManufacturerPages.xaml
    /// </summary>
    public partial class AddManufacturerPages : Page
    {
        public AddManufacturerPages()
        {
            InitializeComponent();
        }

        private void AddManufacturerBtn_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(ManufacturerTb.Text))
                mes += "Введите производителя\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Manufacturer manufacturer = new Manufacturer()
            {
                Name = ManufacturerTb.Text,
            };
            App.context.Manufacturer.Add(manufacturer);
            App.context.SaveChanges();
            MessageBox.Show("Производитель добавлен");

            ManufacturerTb.Text = "";
        }
    }
}
