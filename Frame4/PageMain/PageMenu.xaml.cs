using Frame4.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Frame4.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
        }

        private void P1_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PageMain.PageLD());
            ClassFrame.FrameBody.Navigate(new PageMain.PageBD());
        }

        private void P2_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PageMain.PageLL());
            ClassFrame.FrameBody.Navigate(new PageMain.PageBL());
        }

        private void P3_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PageMain.PageLBux());
            ClassFrame.FrameBody.Navigate(new PageMain.PageBBux());
        }

        private void P4_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PageMain.PageLE());
            ClassFrame.FrameBody.Navigate(new PageMain.PageBE());
        }

        private void P5_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PageMain.PageLM());
            ClassFrame.FrameBody.Navigate(new PageMain.PageBM());
        }

        private void P6_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PageMain.PageLS());
            ClassFrame.FrameBody.Navigate(new PageMain.PageBS());
        }
    }
}
