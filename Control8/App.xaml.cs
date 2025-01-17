using Control8.Model;
using System.Windows;

namespace Control8
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static StudentActivityEntities context = new StudentActivityEntities();
    }
}
