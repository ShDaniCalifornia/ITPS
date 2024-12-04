using Control7.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Control7.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddProductPages.xaml
    /// </summary>
    public partial class AddProductPages : Page
    {
        public AddProductPages()
        {
            InitializeComponent();

            ManufacturerCmb.SelectedValuePath = "ID";
            ManufacturerCmb.DisplayMemberPath = "Name";
            ManufacturerCmb.ItemsSource = App.context.Manufacturer.ToList();
        }

        private void AddProductBtn_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(ProductTb.Text))
                mes += "Введите продукт\n";

            if (string.IsNullOrEmpty(ManufacturerCmb.Text))
                mes += "Введите производителя\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Model.Material material = new Model.Material()
            {
                Name = ProductTb.Text,
                Manufacturer = ManufacturerCmb.SelectedValue as Manufacturer,
            };
            App.context.Material.Add(material);
            App.context.SaveChanges();
            MessageBox.Show("Производитель добавлен");

            ProductTb.Text = "";
            ManufacturerCmb.Text = "";
        }
    }
}
