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
    /// Логика взаимодействия для AddGroupPage.xaml
    /// </summary>
    public partial class AddGroupPage : Page
    {
        public AddGroupPage()
        {
            InitializeComponent();
            SpecializationCmb.SelectedValuePath = "ID";
            SpecializationCmb.DisplayMemberPath = "Name";
            SpecializationCmb.ItemsSource = ClassConnect.context.Specialization.ToList();
        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(GroupTb.Text))
                mes += "Введите группу\n";

            if (string.IsNullOrEmpty(SpecializationCmb.Text))
                mes += "Выберите вид группы\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Group groupDS = new Group()
            {
                Name = GroupTb.Text,
                Specialization = SpecializationCmb.SelectedItem as Specialization
            };
            ClassConnect.context.Group.Add(groupDS);
            ClassConnect.context.SaveChanges();
            MessageBox.Show("Группа добавлена");

            GroupTb.Text = "";
            SpecializationCmb.Text = "";
        }
    }
}
