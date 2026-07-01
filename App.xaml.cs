using FloodWarnApp.Views;
using FloodWarnApp.Services; // Pastikan folder Services terbaca

namespace FloodWarnApp
{
    public partial class App : Application
    {
        // INI DIA YANG HILANG! Kita daftarkan database-nya agar bisa diakses dari semua halaman
        public static DatabaseService Database { get; private set; } = new DatabaseService();

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}