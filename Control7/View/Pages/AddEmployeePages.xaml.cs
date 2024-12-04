using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Control7.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEmployeePages.xaml
    /// </summary>
    public partial class AddEmployeePages : Page
    {
        public AddEmployeePages()
        {
            InitializeComponent();

            EmployeeCmb.SelectedValuePath = "ID";
            EmployeeCmb.DisplayMemberPath = "Name";
            EmployeeCmb.ItemsSource = App.context.Employee.ToList();

            ManufacturerCmb.SelectedValuePath = "ID";
            ManufacturerCmb.DisplayMemberPath = "Name";
            ManufacturerCmb.ItemsSource = App.context.Manufacturer.ToList();

            MaterialrCmb.SelectedValuePath = "ID";
            MaterialrCmb.DisplayMemberPath = "Name";
            MaterialrCmb.ItemsSource = App.context.Material.ToList();
        }

        private void AddEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(EmployeePic.Text))
                mes += "Выберите дату\n";

            if (string.IsNullOrEmpty(EmployeeCmb.Text))
                mes += "Выберите сотрудника\n";

            if (string.IsNullOrEmpty(ManufacturerCmb.Text))
                mes += "Выберите производителя\n";

            if (string.IsNullOrEmpty(MaterialrCmb.Text))
                mes += "Выберите материал\n";

            if (string.IsNullOrEmpty(ProductTb.Text))
                mes += "Введите цену\n";

            if (string.IsNullOrEmpty(QuantityTb.Text))
                mes += "Введите количество\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            //Employee employee = new Employee()
            //{
            //    DateDelivery = (DateTime)EmployeePic.SelectedDate,
            //    Employee = EmployeeCmb.SelectedValue as Employee,
            //    Man = ManufacturerCmb.SelectedValue as Manufacturer,
            //    Material = MaterialrCmb.SelectedValue as Material,
            //    Age = Convert.ToInt32(AgeTb.Text),
            //    Service = ConditionsTb.Text,
            //    DateEnd = (DateTime)EndPic.SelectedDate,
            //};

            //App.context.Journal.Add(journal);
            //App.context.SaveChanges();
            //MessageBox.Show("Результат заполнен");

            //StartPic.Text = "";
            //ViewCmb.Text = "";
            //NicknameTb.Text = "";
            //PassportCb.IsChecked = false;
            //AgeTb.Text = "";
            //ConditionsTb.Text = "";
            //EndPic.Text = "";
        }
    }
}
