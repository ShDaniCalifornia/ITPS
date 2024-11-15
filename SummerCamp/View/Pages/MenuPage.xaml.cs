using SummerCamp.ClassPr;
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

namespace SummerCamp.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void AddGroup_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMenu.Navigate(new View.Pages.MenuPage());
            ClassFrame.FrameBody.Navigate(new View.Pages.AddGroupPage());
        }

        private void AddCompetition_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMenu.Navigate(new View.Pages.MenuPage());
            ClassFrame.FrameBody.Navigate(new View.Pages.AddCompetitionPage());
        }

        private void Counting_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMenu.Navigate(new View.Pages.MenuPage());
            ClassFrame.FrameBody.Navigate(new View.Pages.CountingPage());
        }
    }
}
