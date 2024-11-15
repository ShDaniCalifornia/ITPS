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
using Солнышко.ClassPr;

namespace Солнышко.View.Pagess
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
            ClassKinderGarten.FrameLogo.Navigate(new View.Pagess.LogoPage());
            ClassKinderGarten.FrameBody.Navigate(new View.Pagess.AddGroupPage());
        }

        private void AddEvents_Click(object sender, RoutedEventArgs e)
        {
            ClassKinderGarten.FrameLogo.Navigate(new View.Pagess.LogoPage());
            ClassKinderGarten.FrameBody.Navigate(new View.Pagess.AddEventPage());
        }

        private void Count_Click(object sender, RoutedEventArgs e)
        {
            ClassKinderGarten.FrameLogo.Navigate(new View.Pagess.LogoPage());
            ClassKinderGarten.FrameBody.Navigate(new View.Pagess.CountPage());
        }

        private void CheckJournal_Click(object sender, RoutedEventArgs e)
        {
            ClassKinderGarten.FrameLogo.Navigate(new View.Pagess.LogoPage());
            ClassKinderGarten.FrameBody.Navigate(new View.Pagess.JournalPages());
        }
    }
}
