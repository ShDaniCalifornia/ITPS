using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ЧибисоваTest.Classes;

namespace ЧибисоваTest.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageVybor.xaml
    /// </summary>
    public partial class PageVybor : Page
    {
        public PageVybor()
        {
            InitializeComponent();
            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();

            StudentCmb.SelectedValuePath = "ID";
            StudentCmb.DisplayMemberPath = "Name";
            StudentCmb.ItemsSource = App.context.Student.ToList();

            TestCmb.SelectedValuePath = "ID";
            TestCmb.DisplayMemberPath = "Name";
            TestCmb.ItemsSource = App.context.Test.ToList();

        }

        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedGroup = Convert.ToInt32(GroupCmb.SelectedValue);
            StudentCmb.ItemsSource = App.context.Student.Where(x => x.IdGroup == SelectedGroup).ToList();
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            String mes = "";
            if (string.IsNullOrEmpty(GroupCmb.Text))
                mes += "Выберите группу";
            if (string.IsNullOrEmpty(StudentCmb.Text))
                mes += "Введите название группы";
            if (string.IsNullOrEmpty(TestCmb.Text))
                mes += "Введите название группы";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            else if (TestCmb.Text == "Общие основы функционирования субъектов хозяйствования")
            {
                ClassFrame.FrameBody.Navigate(new View.Pages.PageTest1());
            }
            else if (TestCmb.Text == "Сущность и структура основного капитала и оборотных средств предприятия")
            {
                ClassFrame.FrameBody.Navigate(new View.Pages.PageTest2());
            }
            else if (TestCmb.Text == "Формы и системы оплаты труда")
            {
                ClassFrame.FrameBody.Navigate(new View.Pages.PageTest3());
            }
            else if (TestCmb.Text == "Результаты коммерческой деятельности")
            {
                ClassFrame.FrameBody.Navigate(new View.Pages.PageTest4());
            }

            ClassVariable.classman = Convert.ToInt32(StudentCmb.SelectedValue);
        }
    }
}
