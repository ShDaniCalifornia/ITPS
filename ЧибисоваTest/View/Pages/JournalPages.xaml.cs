using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ЧибисоваTest.Classes;
using ЧибисоваTest.Model;

namespace ЧибисоваTest.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для JournalPages.xaml
    /// </summary>
    public partial class JournalPages : Page
    {
        List<Journal> journal = App.context.Journal.ToList();
        public JournalPages()
        {
            InitializeComponent();
            JournalDG.ItemsSource = App.context.Journal.ToList();

            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();

            StudentCmb.SelectedValuePath = "ID";
            StudentCmb.DisplayMemberPath = "Name";
            StudentCmb.ItemsSource = App.context.Student.ToList();

        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.InterfaceTeacherPages());
        }

        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GroupCmb.SelectedIndex != 0)
            {
                JournalDG.ItemsSource = App.context.Group.Where(group => group.ID == GroupCmb.SelectedIndex).ToList();
            }
            else
            {
                JournalDG.ItemsSource = App.context.Group.ToList();
            }
        }

        private void StudentCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StudentCmb.SelectedIndex != 0)
            {
                JournalDG.ItemsSource = App.context.Student.Where(student => student.ID == StudentCmb.SelectedIndex).ToList();
            }
            else
            {
                JournalDG.ItemsSource = App.context.Student.ToList();
            }
        }
    }
}
