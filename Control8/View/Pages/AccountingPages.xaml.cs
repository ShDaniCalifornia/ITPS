using Control8.Model;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Control8.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AccountingPages.xaml
    /// </summary>
    public partial class AccountingPages : Page
    {
        public AccountingPages()
        {
            InitializeComponent();
            SpecCmb.SelectedValuePath = "ID";
            SpecCmb.DisplayMemberPath = "Name";
            SpecCmb.ItemsSource = App.context.Special.ToList();

            StatusCmb.SelectedValuePath = "ID";
            StatusCmb.DisplayMemberPath = "Name";
            StatusCmb.ItemsSource = App.context.Direction.ToList();

            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();

            ActivityCmb.SelectedValuePath = "ID";
            ActivityCmb.DisplayMemberPath = "Name";
            ActivityCmb.ItemsSource = App.context.Activity.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrEmpty(Pic.Text))
                mes += "Выберите дату\n";

            if (string.IsNullOrEmpty(SpecCmb.Text))
                mes += "Выберите специальность\n";

            if (string.IsNullOrEmpty(StatusCmb.Text))
                mes += "Выберите статус\n";

            if (string.IsNullOrEmpty(GroupCmb.Text))
                mes += "Выберите группу\n";

            if (string.IsNullOrEmpty(ActivityCmb.Text))
                mes += "Выберите соревнование\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Journal journal = new Journal();
            {

            }
        }

        private void SpecCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void StatusCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ActivityCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void JournalDG_Loaded(object sender, RoutedEventArgs e)
        {
            JournalDG.ItemsSource = App.context.Journal.ToList();
        }
    }
}
