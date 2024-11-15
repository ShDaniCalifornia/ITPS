using Fund.Model;
using System.Windows;

namespace Fund
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static FundEntities context = new FundEntities();
    }
}
