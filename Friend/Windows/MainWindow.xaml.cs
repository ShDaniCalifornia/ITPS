using Friend.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Friend
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewCmb.SelectedValuePath = "ID";
            ViewCmb.DisplayMemberPath = "Name";
            ViewCmb.ItemsSource = App.context.ViewAnimal.ToList();
        }

        private void ViewCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void OKBtn_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(StartPic.Text))
                mes += "Выберите дату начала\n";

            if (string.IsNullOrEmpty(ViewCmb.Text))
                mes += "Выберите вид животного\n";

            if (string.IsNullOrEmpty(NicknameTb.Text))
                mes += "Впишите кличку\n";

            if (string.IsNullOrEmpty(AgeTb.Text))
                mes += "Впишите возраст\n";

            if (string.IsNullOrEmpty(ConditionsTb.Text))
                mes += "Впишите условия содержания\n";

            if (string.IsNullOrEmpty(EndPic.Text))
                mes += "Выберите дату окончания\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Journal journal = new Journal()
            {
                DateStart = (DateTime)StartPic.SelectedDate,
                ViewAnimal = ViewCmb.SelectedValue as ViewAnimal,
                Nickname = NicknameTb.Text,
                Passport = PassportCb.IsChecked == true,
                Age = Convert.ToInt32(AgeTb.Text),
                Service = ConditionsTb.Text,
                DateEnd = (DateTime)EndPic.SelectedDate,
            };

            App.context.Journal.Add(journal);
            App.context.SaveChanges();
            MessageBox.Show("Результат заполнен");

            StartPic.Text = "";
            ViewCmb.Text = "";
            NicknameTb.Text = "";
            PassportCb.IsChecked = false;
            AgeTb.Text = "";
            ConditionsTb.Text = "";
            EndPic.Text = "";

        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = App.context.Journal.ToList();
        }
    }
}

