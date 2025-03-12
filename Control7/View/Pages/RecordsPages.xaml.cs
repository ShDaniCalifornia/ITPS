using Control7.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Control7.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для RecordsPages.xaml
    /// </summary>
    public partial class RecordsPages : Page
    {
        public RecordsPages()
        {
            InitializeComponent();
            InitializeComponent();
            EmployeeCmb.SelectedValuePath = "ID";
            EmployeeCmb.DisplayMemberPath = "Name";
            EmployeeCmb.ItemsSource = App.context.Employee.ToList();
        }

        private void AddEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";

            if (string.IsNullOrEmpty(StartPic.Text))
                mes += "Выберите дату начала периода\n";

            if (string.IsNullOrEmpty(EndPic.Text))
                mes += "Выберите дату конца периода\n";

            if (string.IsNullOrEmpty(EmployeeCmb.Text))
                mes += "Выберите сотрудника\n";

            if (string.IsNullOrEmpty(RecordsTb.Text))
                mes += "Введите сколько всего записей\n";

            if (string.IsNullOrEmpty(SumTb.Text))
                mes += "Введите общую сумму\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Acounting acounting = new Acounting()
            {
                DateDelivery = (DateTime)StartPic.SelectedDate,
                Employee = EmployeeCmb.SelectedItem as Employee,
                Quantity = Convert.ToInt32(RecordsTb.Text),
                Amount = Convert.ToDecimal(SumTb.Text)
            };

            App.context.Acounting.Add(acounting);
            App.context.SaveChanges();
            MessageBox.Show("Запись добавлена");
            RecordsDG.ItemsSource = App.context.Acounting.ToList();

            StartPic.Text = "";
            EndPic.Text = "";
            EmployeeCmb.Text = "";
            RecordsTb.Text = "";
            RecordsTb.Text = "";
        }

        private void RecordsDG_Loaded(object sender, RoutedEventArgs e)
        {
            RecordsDG.ItemsSource = App.context.Acounting.ToList();
        }
    }
}
