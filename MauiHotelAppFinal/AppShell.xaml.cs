using MauiHotelAppFinal.Views;

namespace MauiHotelAppFinal
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Sobre), typeof(Sobre));
        }
    }
}
