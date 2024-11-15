using Fund.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Fund
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GenreCmb.SelectedValuePath = "ID";
            GenreCmb.DisplayMemberPath = "GenreName";
            GenreCmb.ItemsSource = App.context.Genres.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            {
                String mes = "";
                if (string.IsNullOrEmpty(StartPic.Text))
                    mes += "Выберите дату поступления книги\n";

                if (string.IsNullOrEmpty(GenreCmb.Text))
                    mes += "Выберите жанр произведения\n";

                if (string.IsNullOrEmpty(AuthorTb.Text))
                    mes += "Впишите имя автора\n";

                if (string.IsNullOrEmpty(TitleTb.Text))
                    mes += "Впишите название книги\n";

                if (string.IsNullOrEmpty(YearTb.Text))
                    mes += "Впишите год издания\n";

                if (mes != "")
                {
                    MessageBox.Show(mes);
                    mes = "";
                    return;
                }

                Books newBook = new Books()
                {
                    DateOfReceipt = (DateTime)StartPic.SelectedDate,
                    Genres = GenreCmb.SelectedItem as Genres,
                    AuthorName = AuthorTb.Text,
                    BookTitle = TitleTb.Text,
                    PublicationYear = Convert.ToInt32(YearTb.Text),
                    IsInMandatoryReadingList = EductCb.IsChecked == true,
                };

                App.context.Books.Add(newBook);
                App.context.SaveChanges();
                MessageBox.Show("Книга добавлена");
                BooksDG.ItemsSource = App.context.Books.ToList();

                StartPic.Text = "";
                GenreCmb.Text = "";
                EductCb.IsChecked = false;
                AuthorTb.Text = "";
                TitleTb.Text = "";
                YearTb.Text = "";
            }
        }

        private void GenreCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BooksDG_Loaded(object sender, RoutedEventArgs e)
        {
            BooksDG.ItemsSource = App.context.Books.ToList();
        }
    }
}
