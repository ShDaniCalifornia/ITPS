using Control7.AppData;
using System.Windows;

namespace Control7.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ClassFrame.FrameBody = FrameBody;
            FrameBody.Navigate(new View.Pages.MainPages());

            ClassFrame.FramePanel = FramePanel;
            FramePanel.Navigate(new View.Pages.PanelPages());
        }
    }
}
