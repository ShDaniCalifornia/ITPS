using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Control7.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ReportPages.xaml
    /// </summary>
    public partial class ReportPages : Page
    {
        public ReportPages()
        {
            InitializeComponent();
        }

        private void ReportBtn_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(StartPic.Text))
                mes += "Выберите начало периода\n";

            if (string.IsNullOrEmpty(EndPic.Text))
                mes += "Выберите конец периода\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            var a = (DateTime)StartPic.SelectedDate;
            var b = (DateTime)EndPic.SelectedDate;

            var qwery = App.context.View_1
                .Where(x => x.DateDelivery >= a && x.DateDelivery <= b)
                .GroupBy(y => y.Name)
                .Select(g => new { Сотрудник = g.Key, Сумма = g.Sum(s => s.Amount) })
                .OrderBy(n => n.Сотрудник);

            DataGr1.ItemsSource = qwery.ToList();
        }
    }
}
