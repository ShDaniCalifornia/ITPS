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
using Солнышко.Model;

namespace Солнышко.View.Pagess
{
    /// <summary>
    /// Логика взаимодействия для CountPage.xaml
    /// </summary>
    public partial class CountPage : Page
    {
        public CountPage()
        {
            InitializeComponent();

            CmbS.SelectedValuePath = "ID";
            CmbS.DisplayMemberPath = "Name";
            CmbS.ItemsSource = ClassConnect.context.ViewGroup.ToList();

            CmbSt.SelectedValuePath = "ID";
            CmbSt.DisplayMemberPath = "Name";
            CmbSt.ItemsSource = ClassConnect.context.Group.ToList();

            CmbG.SelectedValuePath = "ID";
            CmbG.DisplayMemberPath = "Name";
            CmbG.ItemsSource = ClassConnect.context.Direction.ToList();

            CmbC.SelectedValuePath = "ID";
            CmbC.DisplayMemberPath = "Name";
            CmbC.ItemsSource = ClassConnect.context.Activity.ToList();

            CmbM.SelectedValuePath = "ID";
            CmbM.DisplayMemberPath = "Name";
            CmbM.ItemsSource = ClassConnect.context.Mark.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(Pic.Text))
                mes += "Выберите дату\n";
            if (string.IsNullOrEmpty(CmbG.Text))
                mes += "Выберите группу\n";

            if (string.IsNullOrEmpty(CmbS.Text))
                mes += "Выберите вид группы\n";

            if (string.IsNullOrEmpty(CmbSt.Text))
                mes += "Выберите вид мероприятия\n";

            if (string.IsNullOrEmpty(CmbC.Text))
                mes += "Выберите мероприятие\n";

            if (string.IsNullOrEmpty(CmbM.Text))
                mes += "Выберите оценку\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Journal journal = new Journal()
            {
                DataLesson = (DateTime)Pic.SelectedDate,
                Group = CmbG.SelectedItem as Group,
                Activity = CmbC.SelectedItem as Activity,
                Mark = CmbM.SelectedItem as Mark,
            };

            ClassConnect.context.Journal.Add(journal);
            ClassConnect.context.SaveChanges();
            MessageBox.Show("Оценка добавлена");

            Pic.Text = "";
            CmbS.Text = "";
            CmbSt.Text = "";
            CmbG.Text = "";
            CmbC.Text = "";
            CmbM.Text = "";
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassKinderGarten.FrameBody.GoBack();
        }

        private void CmbS_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedVG = Convert.ToInt32(CmbS.SelectedValue);
            CmbSt.ItemsSource = ClassConnect.context.Group.Where(x => x.IdViewGroup == SelectedVG).ToList();
        }

        private void CmbG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedVA = Convert.ToInt32(CmbG.SelectedValue);
            CmbC.ItemsSource = ClassConnect.context.Activity.Where(x => x.IdDirection == SelectedVA).ToList();
        }
    }
}
