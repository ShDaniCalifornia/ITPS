using System.Windows;
using ЧибисоваTest.Classes;

namespace ЧибисоваTest.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow()
        {
            InitializeComponent();

            ClassFrame.FrameBody = FrameBody;
            FrameBody.Navigate(new View.Pages.PageTest1());
        }
    }
}
