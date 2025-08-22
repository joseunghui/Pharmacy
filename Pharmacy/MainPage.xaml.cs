namespace Pharmacy
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        private async void goOTCDrug(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(OTCManagementPage));
        }

        private async void goETCDrug(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ETCManagementPage));
        }
    }
}
