using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.Utils.MVVM.Services;
using DevExpress.Utils.MVVM;
using DevExpress.XtraBars.Navigation;

namespace CadastroDesktop.Views.ContextoView{
    public partial class ContextoView : XtraUserControl {
        public ContextoView() {
		     InitializeComponent();
			 if(!mvvmContext.IsDesignMode)
                InitializeNavigation();
        }
        void InitializeNavigation() {
			DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            float fontSize = 10f;
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Segoe UI", fontSize);
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultMenuFont = new System.Drawing.Font("Segoe UI", fontSize);

			tileBar.SelectionColorMode = SelectionColorMode.UseItemBackColor;
            mvvmContext.RegisterService(DocumentManagerService.Create(navigationFrame));
            DevExpress.Utils.MVVM.MVVMContext.RegisterFlyoutDialogService();
            // We want to use buttons in Ribbon to show the specific modules
            var fluentAPI = mvvmContext.OfType<CadastroDesktop.ViewModels.ContextoViewModel>();
						tileBar.SelectedItem = tileBarItemClienteCollectionView;

			            fluentAPI.BindCommand(tileBarItemClienteCollectionView, (x, m) => x.Show(m), x => x.Modules[0]);
						            // We want show the default module when our UserControl is loaded
            fluentAPI.WithEvent<EventArgs>(this, "Load")
                .EventToCommand(x => x.OnLoaded(null), x => x.DefaultModule);
		
        }
    }
}
