using SummerCamp.ClassPr;
using SummerCamp.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SummerCamp.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для CountingPage.xaml
    /// </summary>
    public partial class CountingPage : Page
    {
        public CountingPage()
        {
            InitializeComponent();
            SpecCmb.SelectedValuePath = "ID";
            SpecCmb.DisplayMemberPath = "Name";
            SpecCmb.ItemsSource = ClassConnect.context.Specialization.ToList();

            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = ClassConnect.context.Group.ToList();

            CompetitionCmb.SelectedValuePath = "ID";
            CompetitionCmb.DisplayMemberPath = "Name";
            CompetitionCmb.ItemsSource = ClassConnect.context.TypeCompetition.ToList();

            StatusCmb.SelectedValuePath = "ID";
            StatusCmb.DisplayMemberPath = "Name";
            StatusCmb.ItemsSource = ClassConnect.context.Direction.ToList();
        }

        private void CountDataGr_Loaded(object sender, RoutedEventArgs e)
        {
            CountDataGr.ItemsSource = ClassConnect.context.Accounting.ToList();
        }


        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(Pic.Text))
                mes += "Выберите дату\n";

            if (string.IsNullOrEmpty(SpecCmb.Text))
                mes += "Выберите специальность\n";

            if (string.IsNullOrEmpty(StatusCmb.Text))
                mes += "Выберите статус соревнования\n";

            if (string.IsNullOrEmpty(CompetitionCmb.Text))
                mes += "Выберите соревнование\n";

            if (string.IsNullOrEmpty(GroupCmb.Text))
                mes += "Выберите группу\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Accounting accounting = new Accounting()
            {
                DateGame = (DateTime)Pic.SelectedDate,
                Group = GroupCmb.SelectedItem as Group,
                TypeCompetition = CompetitionCmb.SelectedItem as TypeCompetition,
                Evaluation = Convert.ToDecimal(EvaluationTb.Text)
            };

            ClassConnect.context.Accounting.Add(accounting);
            ClassConnect.context.SaveChanges();
            MessageBox.Show("Результат заполнен");

            Pic.Text = "";
            SpecCmb.Text = "";
            GroupCmb.Text = "";
            CompetitionCmb.Text = "";
            StatusCmb.Text = "";

            CountDataGr.ItemsSource = ClassConnect.context.Accounting.ToList();
        }


        private void SpecCmb_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            int SelectedSG = Convert.ToInt32(SpecCmb.SelectedValue);
            GroupCmb.ItemsSource = ClassConnect.context.Group.Where(x => x.ID == SelectedSG).ToList();
        }

        private void StatusCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedSC = Convert.ToInt32(StatusCmb.SelectedValue);
            CompetitionCmb.ItemsSource = ClassConnect.context.TypeCompetition.Where(x => x.ID == SelectedSC).ToList();
        }
    }
}
