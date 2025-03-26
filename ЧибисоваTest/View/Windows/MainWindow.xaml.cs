using System.Windows;
using ЧибисоваTest.Classes;

namespace ЧибисоваTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ClassFrame.FrameLogo = FrameLogo;
            FrameLogo.Navigate(new View.Pages.LogoPages());

            ClassFrame.FrameBody = FrameBody;
            FrameBody.Navigate(new View.Pages.MainPages());
        }
    }
}
