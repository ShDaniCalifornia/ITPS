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

            SpecialCmb.SelectedValuePath = "ID";
            SpecialCmb.DisplayMemberPath = "Name";
            SpecialCmb.ItemsSource = App.context.Special.ToList();
        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(GroupTb.Text))
                mes += "Введите группу\n";

            if (string.IsNullOrEmpty(SpecialCmb.Text))
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
                Special = SpecialCmb.SelectedItem as Special
            };
            App.context.Group.Add(group);
            App.context.SaveChanges();
            MessageBox.Show("Группа добавлена");

            GroupTb.Text = "";
            SpecialCmb.Text = "";
        }
    }
}
