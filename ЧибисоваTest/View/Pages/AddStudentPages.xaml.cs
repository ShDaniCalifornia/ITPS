using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ЧибисоваTest.Classes;
using ЧибисоваTest.Model;

namespace ЧибисоваTest.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddStudentPages.xaml
    /// </summary>
    public partial class AddStudentPages : Page
    {
        public AddStudentPages()
        {
            InitializeComponent();

            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(NameTb.Text))
                mes += "Введите ФИО студента";

            if (string.IsNullOrEmpty(GroupCmb.Text))
                mes += "Выберите группу";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Student student = new Student()
            {
                Name = NameTb.Text,
                Group = GroupCmb.SelectedItem as Group
            };

            App.context.Student.Add(student);
            App.context.SaveChanges();
            MessageBox.Show("Студент добавлен!");
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.InterfaceTeacherPages());
        }
    }
}
