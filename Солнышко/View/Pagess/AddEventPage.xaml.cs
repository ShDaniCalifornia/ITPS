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
    /// Логика взаимодействия для AddEventPage.xaml
    /// </summary>
    public partial class AddEventPage : Page
    {
        public AddEventPage()
        {
            InitializeComponent();
            CmbVE.SelectedValuePath = "ID";
            CmbVE.DisplayMemberPath = "Name";
            CmbVE.ItemsSource = ClassConnect.context.Activity.ToList();
        }


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddEvent_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(TxtEvent.Text))
                mes += "Введите пероприятие\n";

            if (string.IsNullOrEmpty(CmbVE.Text))
                mes += "Выберите вид мероприятия\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Activity EventDS = new Activity()
            {
                Name = TxtEvent.Text,
                Direction = CmbVE.SelectedItem as Direction
            };

            ClassConnect.context.Activity.Add(EventDS);
            ClassConnect.context.SaveChanges();
            MessageBox.Show("Мероприятие добавлено");

            TxtEvent.Text = "";
            CmbVE.Text = "";

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ClassKinderGarten.FrameBody.GoBack();
        }
    }
}
