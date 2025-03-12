using Control8.Class;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace Control8.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для OneReportPages.xaml
    /// </summary>
    public partial class OneReportPages : Page
    {
        public OneReportPages()
        {
            InitializeComponent();
            CmbSpecial.SelectedValuePath = "ID";
            CmbSpecial.DisplayMemberPath = "Name";
            CmbSpecial.ItemsSource = App.context.Special.ToList();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            int Selected = Convert.ToInt32(CmbSpecial.SelectedValue);

            DataGridInfo.ItemsSource = App.context.Group.Where(x => x.IdSpecial == Selected).ToList();
        }

        private void BallBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.TwoReportPages((sender as Button).DataContext as Group));
        }
    }
}
