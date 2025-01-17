using Control8.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Control8.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddGroupPages.xaml
    /// </summary>
    public partial class AddGroupPages : Page
    {
        public AddGroupPages()
        {
            InitializeComponent();

            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();
        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(GroupTb.Text))
                mes += "Введите группу\n";

            if (string.IsNullOrEmpty(GroupCmb.Text))
                mes += "Выберите специальность\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Group group = new Group()
            {
                Name = GroupTb.Text,
                Special = GroupCmb.SelectedItem as Special
            };
            App.context.Group.Add(group);
            App.context.SaveChanges();
            MessageBox.Show("Группа добавлена");

            GroupTb.Text = "";
            GroupCmb.Text = "";
        }
    }
}
