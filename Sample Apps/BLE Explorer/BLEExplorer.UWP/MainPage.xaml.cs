namespace BLEExplorer.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            global::BLEExplorer.App.SetAdapter(new Robotics.Mobile.Core.Bluetooth.LE.Adapter());

            LoadApplication(new BLEExplorer.App());
        }
    }
}