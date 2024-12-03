using Pharmacy.Model;
using System.Windows;

namespace Pharmacy
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static PharmacyEntities context = new PharmacyEntities();
    }
}
