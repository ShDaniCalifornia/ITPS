using Control8.Class;
using System.Windows;

namespace Control8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ClassFrame.FrameMenu = FrameMenu;
            FrameMenu.Navigate(new View.Pages.MenuPages());

            ClassFrame.FrameBody = FrameBody;
            FrameBody.Navigate(new View.Pages.BodyPages());
        }
    }
}
