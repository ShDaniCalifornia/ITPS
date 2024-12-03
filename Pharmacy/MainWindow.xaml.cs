using Pharmacy.Model;
using System;
using System.Linq;
using System.Windows;

namespace Pharmacy
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            ManufacturerCmb.SelectedValuePath = "IDManufacturer";
            ManufacturerCmb.DisplayMemberPath = "Name";
            ManufacturerCmb.ItemsSource = App.context.Manufacturer.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(NameTb.Text))
                mes += "Введите название\n";

            if (string.IsNullOrEmpty(PriceTb.Text))
                mes += "Введите цену\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Model.Material material = new Model.Material()
            {
                Name = NameTb.Text,
                Price = Convert.ToDecimal(PriceTb.Text),
                Manufacturer = ManufacturerCmb.SelectedItem as Manufacturer,
            };

            App.context.Material.Add(material);
            App.context.SaveChanges();
            MessageBox.Show("Успешно добавлено!");

            NameTb.Text = "";
            PriceTb.Text = "";
            ManufacturerCmb.Text = "";
        }

        private void PharmacyGr_Loaded(object sender, RoutedEventArgs e)
        {
            PharmacyGr.ItemsSource = App.context.Material.ToList();
        }

        private void ManufacturerCmb_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
