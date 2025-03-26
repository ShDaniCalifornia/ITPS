using System.Windows;
using System.Windows.Controls;
using ЧибисоваTest.Classes;

namespace ЧибисоваTest.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginTeacherPages.xaml
    /// </summary>
    public partial class LoginTeacherPages : Page
    {
        public LoginTeacherPages()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordPb.Password == "123")
            {
                MessageBox.Show("Вы успешно вошли в систему!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                ClassFrame.FrameBody.Navigate(new View.Pages.InterfaceTeacherPages());
            }
            else
            {
                MessageBox.Show("Пароль введен неверно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
