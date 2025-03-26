using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ЧибисоваTest.Classes;
using ЧибисоваTest.Model;

namespace ЧибисоваTest.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для DeletePages.xaml
    /// </summary>
    public partial class DeletePages : Page
    {
        List<Student> student = App.context.Student.ToList();
        public DeletePages()
        {
            InitializeComponent();
            StudentDG.ItemsSource = App.context.Student.ToList();

            StudentCmb.SelectedValuePath = "ID";
            StudentCmb.DisplayMemberPath = "Name";
            StudentCmb.ItemsSource = App.context.Student.ToList();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = (Student)StudentDG.SelectedItem;

            if (selectedStudent != null)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить студента?", "Подтверждение удаления", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    // // Удаление связанных записей из Group
                    var relatedGroups = App.context.Group.Where(gr => gr.ID == selectedStudent.ID).ToList();
                    foreach (var group in relatedGroups)
                    {
                        App.context.Group.Remove(group);
                    }

                    // Удаление связанных записей из Journal
                    var relatedJournal = App.context.Journal.Where(j => j.ID == selectedStudent.ID).ToList();
                    foreach (var journal in relatedJournal)
                    {
                        App.context.Journal.Remove(journal);
                    }

                    // Теперь можно удалить книгу
                    App.context.Student.Remove(selectedStudent);
                    App.context.SaveChanges();

                    // Обновляем список отображаемых книг
                    StudentDG.ItemsSource = App.context.Student.ToList();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите студента для удаления.");
            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.InterfaceTeacherPages());
        }

        private void StudentCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StudentCmb.SelectedIndex != 0)
            {
                StudentDG.ItemsSource = App.context.Student.Where(student => student.ID == StudentCmb.SelectedIndex).ToList();
            }
            else
            {
                StudentDG.ItemsSource = App.context.Student.ToList();
            }
        }

    }
}
