using System.Windows;
using ЧибисоваTest.Model;

namespace ЧибисоваTest
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ЧибисоваTestEntities context = new ЧибисоваTestEntities();
    }
}
