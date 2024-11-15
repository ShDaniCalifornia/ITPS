using Control7.AppData;
using System.Windows;

namespace Control7
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

        }
    }
}
