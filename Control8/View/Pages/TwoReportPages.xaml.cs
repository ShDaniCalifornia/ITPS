using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Control8.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TwoReportPages.xaml
    /// </summary>
    public partial class TwoReportPages : Page
    {
        public TwoReportPages()
        {
            InitializeComponent();
            GridJournal.ItemsSource = App.context.Journal.Where(x => x.IdGroup == group.ID).ToList();
        }

        private void PrintBtn_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true) printDialog.PrintVisual(GridJournal, "Баллы");
        }
    }
}
