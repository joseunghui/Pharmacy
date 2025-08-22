namespace Pharmacy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Page 이동
            MainPage = new AppShell();
        }

    }
}