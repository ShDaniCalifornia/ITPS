using SummerCamp.ClassPr;
using SummerCamp.Model;
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
    /// Логика взаимодействия для AddCompetitionPage.xaml
    /// </summary>
    public partial class AddCompetitionPage : Page
    {
        public AddCompetitionPage()
        {
            InitializeComponent();
            TypeCompetitionCmb.SelectedValuePath = "ID";
            TypeCompetitionCmb.DisplayMemberPath = "Name";
            TypeCompetitionCmb.ItemsSource = ClassConnect.context.Direction.ToList();
        }

        private void AddCompetitionBtn_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(CompetitonTb.Text))
                mes += "Введите соревнование\n";

            if (string.IsNullOrEmpty(TypeCompetitionCmb.Text))
                mes += "Выберите вид соревнования\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            TypeCompetition directionDS = new TypeCompetition()
            {
                Name = CompetitonTb.Text,
                Direction = TypeCompetitionCmb.SelectedItem as Direction
            };

            ClassConnect.context.TypeCompetition.Add(directionDS);
            ClassConnect.context.SaveChanges();
            MessageBox.Show("Группа добавлена");

            CompetitonTb.Text = "";
            TypeCompetitionCmb.Text = "";
        }
    }
}
