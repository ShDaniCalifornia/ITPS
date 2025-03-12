using System.Windows;
using System.Windows.Controls;
using ЧибисоваTest.Classes;

namespace ЧибисоваTest.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для InterfaceTeacherPages.xaml
    /// </summary>
    public partial class InterfaceTeacherPages : Page
    {
        public InterfaceTeacherPages()
        {
            InitializeComponent();
        }

        private void AddStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.AddStudentPages());
        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.AddGroupPages());
        }

        private void JournalBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.JournalPages());
        }

        private void DeleteStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.DeletePages());
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.MainPages());
        }
    }
}
