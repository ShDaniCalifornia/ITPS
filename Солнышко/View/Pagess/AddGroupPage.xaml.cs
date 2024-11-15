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
    /// Логика взаимодействия для AddGroupPage.xaml
    /// </summary>
    public partial class AddGroupPage : Page
    {
        public AddGroupPage()
        {
            InitializeComponent();
            CmbVG.SelectedValuePath = "ID";
            CmbVG.DisplayMemberPath = "Name";
            CmbVG.ItemsSource = ClassConnect.context.ViewGroup.ToList();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ClassKinderGarten.FrameBody.GoBack();
        }

        private void AddGroup_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(TxtGroup.Text))
                mes += "Введите группу\n";

            if (string.IsNullOrEmpty(CmbVG.Text))
                mes += "Выберите вид группы\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Group groupDS = new Group()
            {
                Name = TxtGroup.Text,
                ViewGroup = CmbVG.SelectedItem as ViewGroup
            };
            ClassConnect.context.Group.Add(groupDS);
            ClassConnect.context.SaveChanges();
            MessageBox.Show("Группа добавлена");

            TxtGroup.Text = "";
            CmbVG.Text = "";

        }
    }
}