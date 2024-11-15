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
    /// Логика взаимодействия для JournalPages.xaml
    /// </summary>
    public partial class JournalPages : Page
    {
        public JournalPages()
        {
            InitializeComponent();
            CmbGroup.SelectedValuePath = "ID";
            CmbGroup.DisplayMemberPath = "Name";
            CmbGroup.ItemsSource = ClassConnect.context.Group.ToList();
        }

        private void ExitBnt_Click(object sender, RoutedEventArgs e)
        {
            ClassKinderGarten.FrameBody.GoBack();
        }

        private void DatGr_Loaded(object sender, RoutedEventArgs e)
        {
            DatGr.ItemsSource = ClassConnect.context.Journal.ToList();
        }

        private void CmbGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedG = Convert.ToInt32(CmbGroup.SelectedValue);
            DatGr.ItemsSource = ClassConnect.context.Journal.Where(x => x.IdGroup == SelectedG).ToList();
        }
    }
}
