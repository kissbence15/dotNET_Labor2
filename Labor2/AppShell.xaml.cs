namespace Labor2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("Feladat1Page", typeof(MainPage));
            Routing.RegisterRoute("Feladat2Page", typeof(Feladat2Page));
            Routing.RegisterRoute("Feladat3Page", typeof(Feladat3Page));
            Routing.RegisterRoute("Feladat4Page", typeof(Feladat4Page));
            Routing.RegisterRoute("Feladat5Page", typeof(Feladat5Page));
            Routing.RegisterRoute("Feladat6Page", typeof(Feladat6Page));
        }
    }
}
