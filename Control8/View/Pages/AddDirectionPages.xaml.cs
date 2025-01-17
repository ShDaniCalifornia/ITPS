using Control8.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Control8.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddDirectionPages.xaml
    /// </summary>
    public partial class AddDirectionPages : Page
    {
        public AddDirectionPages()
        {
            InitializeComponent();

            DirectionCmb.SelectedValuePath = "ID";
            DirectionCmb.DisplayMemberPath = "Name";
            DirectionCmb.ItemsSource = App.context.Direction.ToList();
        }

        private void AddDirectionBtn_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(ActivityTb.Text))
                mes += "Введите сореванование\n";

            if (string.IsNullOrEmpty(DirectionCmb.Text))
                mes += "Выберите вид\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Activity activity = new Activity()
            {
                Name = ActivityTb.Text,
                Direction = DirectionCmb.SelectedItem as Direction
            };
            App.context.Activity.Add(activity);
            App.context.SaveChanges();
            MessageBox.Show("Соревнование добавлено");

            ActivityTb.Text = "";
            DirectionCmb.Text = "";
        }
    }
}
