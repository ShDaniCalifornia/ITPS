using System;
using System.Windows;
using System.Windows.Controls;
using ЧибисоваTest.Classes;
using ЧибисоваTest.Model;

namespace ЧибисоваTest.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddGroupPages.xaml
    /// </summary>
    public partial class AddGroupPages : Page
    {
        public AddGroupPages()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(GroupTb.Text))
                mes += "Введите название группы";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Group group = new Group()
            {
                Name = GroupTb.Text,
            };

            App.context.Group.Add(group);
            App.context.SaveChanges();
            MessageBox.Show("Группа добавлена!");
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.InterfaceTeacherPages());
        }
    }
}
