using System;
using System.Windows;
using System.Windows.Controls;
using ЧибисоваTest.Classes;
using ЧибисоваTest.Model;

namespace ЧибисоваTest.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageTest1.xaml
    /// </summary>
    public partial class PageTest1 : Page
    {
        int b = 0;
        int c = 0;
        public PageTest1()
        {
            InitializeComponent();
        }

        private void P2_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "5")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P1.Visibility = Visibility.Collapsed;
            products.SelectedItem = v3;
        }

        private void P1_Click(object sender, RoutedEventArgs e)
        {
            if (RB2.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P2.Visibility = Visibility.Collapsed;
            products.SelectedItem = v2;
        }

        private void P3_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "5")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P3.Visibility = Visibility.Collapsed;
            products.SelectedItem = v4;
        }

        private void P4_Click(object sender, RoutedEventArgs e)
        {
            if (CHB1.IsChecked == true && CHB2.IsChecked == true && CHB4.IsChecked == true && CHB5.IsChecked == true && CHB3.IsChecked == false)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P4.Visibility = Visibility.Collapsed;
            products.SelectedItem = v5;
        }


        private void P5_Click_1(object sender, RoutedEventArgs e)

        {
            if (TextBox5.Text == "3")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P5.Visibility = Visibility.Collapsed;
            products.SelectedItem = v6;
        }

        private void P6_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox6.Text == "4")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P6.Visibility = Visibility.Collapsed;
            products.SelectedItem = v7;
        }

        private void P7_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox7.Text == "5")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P7.Visibility = Visibility.Collapsed;
            products.SelectedItem = v8;
        }

        private void P8_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox8.Text == "5")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P8.Visibility = Visibility.Collapsed;
            products.SelectedItem = v9;
        }

        private void P9_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox9.Text == "4")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P9.Visibility = Visibility.Collapsed;
            products.SelectedItem = v10;
        }

        private void P10_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox10.Text == "4")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P10.Visibility = Visibility.Collapsed;
            products.SelectedItem = v11;
        }

        private void P11_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox11.Text == "1")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P11.Visibility = Visibility.Collapsed;
            products.SelectedItem = v12;
        }

        private void P12_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox12.Text == "1") // Правильный ответ – "1"
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P12.Visibility = Visibility.Collapsed;
            products.SelectedItem = v13;
        }

        private void P13_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox13.Text == "1")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P13.Visibility = Visibility.Collapsed;
            products.SelectedItem = v14;
        }

        private void P14_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox14.Text == "1")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P14.Visibility = Visibility.Collapsed;
            products.SelectedItem = v15;
        }

        private void P15_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox15.Text == "2")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P15.Visibility = Visibility.Collapsed;
            products.SelectedItem = v16;
        }

        private void P16_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox16.Text == "1")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P16.Visibility = Visibility.Collapsed;
            products.SelectedItem = v17;
        }

        private void P17_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox17.Text == "3")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P17.Visibility = Visibility.Collapsed;
            products.SelectedItem = v18;
        }

        private void P18_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox18.Text == "1")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P18.Visibility = Visibility.Collapsed;
            products.SelectedItem = v19;
        }

        private void P19_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox19.Text == "4")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P19.Visibility = Visibility.Collapsed;
            products.SelectedItem = v20;
        }

        private void P20_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox20.Text == "2")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            P20.Visibility = Visibility.Collapsed;
            products.SelectedItem = v21;
        }

        private void P21_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox21.Text == "2") // Правильный ответ – "2"
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else
            {
                MessageBox.Show("Неправильно");
            }

            P21.Visibility = Visibility.Collapsed;
        }

        private void p0_Click(object sender, RoutedEventArgs e)
        {
            TextBlock100.Text = Convert.ToString(b);

            if (b >= 20) c = 5;
            if ((b > 11) && (b < 20)) c = 4;
            if ((b > 5) && (b < 12)) c = 3;
            if ((b < 6) && (b > 0)) c = 3;
            if (b == 0) c = 1;

            TextBlock101.Text = Convert.ToString(c);
        }

        private void p00_Click(object sender, RoutedEventArgs e)
        {
            Journal journal = new Journal()
            {
                DateTest = DateTime.Now,
                Mark = c,
                IdStudent = ClassVariable.classman,
                IdTest = 1
            };

            App.context.Journal.Add(journal);
            App.context.SaveChanges();

            ClassFrame.FrameBody.Navigate(new View.Pages.MainPages());
        }
    }
}
