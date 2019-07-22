using Syncfusion.SfDataGrid.XForms.UWP;

namespace EPYSLAPPS.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

			SfDataGridRenderer.Init();

            LoadApplication(new EPYSLAPPS.App());
        }
    }
}
