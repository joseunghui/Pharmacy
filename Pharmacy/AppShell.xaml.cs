namespace Pharmacy
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // 라우트 등록
            Routing.RegisterRoute(nameof(OTCManagementPage), typeof(OTCManagementPage));

            Routing.RegisterRoute(nameof(ETCManagementPage), typeof(ETCManagementPage));
        }
    }
}
