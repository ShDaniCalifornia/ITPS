using Control8.Model;
using System;
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

            if (string.IsNullOrEmpty(MarkTb.Text))
                mes += "Впишите оценку\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Journal journal = new Journal()
            {
                DateEvent = (DateTime)Pic.SelectedDate,
                Group = GroupCmb.SelectedItem as Group,
                Activity = ActivityCmb.SelectedItem as Activity,
                Mark = Convert.ToDecimal(MarkTb.Text)
            };


            App.context.Journal.Add(journal);
            App.context.SaveChanges();
            MessageBox.Show("Запись добавлена");
            JournalDG.ItemsSource = App.context.Journal.ToList();

            Pic.Text = "";
            SpecCmb.Text = "";
            StatusCmb.Text = "";
            GroupCmb.Text = "";
            ActivityCmb.Text = "";
            MarkTb.Text = "";
        }

        private void SpecCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedGS = Convert.ToInt32(SpecCmb.SelectedValue);
            GroupCmb.ItemsSource = App.context.Group.Where(x => x.IdSpecial == SelectedGS).ToList();
        }

        private void StatusCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedAD = Convert.ToInt32(StatusCmb.SelectedValue);
            ActivityCmb.ItemsSource = App.context.Activity.Where(x => x.IdDirection == SelectedAD).ToList();
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
