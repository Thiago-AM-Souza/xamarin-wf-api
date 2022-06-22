namespace CadastroDesktop.Views.ContextoView {
    partial class ContextoView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		 #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarGroupViews = new DevExpress.XtraBars.Navigation.TileBarGroup();
						this.tileBarItemClienteCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
						            this.SuspendLayout();
			/// 
            // tileBar
            // 
            this.tileBar.AllowDrag = false;
			this.tileBar.AllowGlyphSkinning = true;
			this.tileBar.AllowSelectedItem = true;
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.Groups.Add(this.tileBarGroupViews);
			this.tileBar.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(29, 11, 29, 11);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
			this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.WideTileWidth = 150;
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 110);
			this.tileBar.MaximumSize = new System.Drawing.Size(0, 110);
			this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.Text = "tileBar";
			//
			//tileBarGroupTables
			//
			this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
			// 
            // tileBarGroupViews
            // 
            this.tileBarGroupViews.Name = "tileBarGroupViews";
            this.tileBarGroupViews.Text = "VIEWS";
            			//
			//tileBarItemClienteCollectionView
			//
			DevExpress.XtraEditors.TileItemElement tileItemElementClienteCollectionView = new DevExpress.XtraEditors.TileItemElement();
            tileItemElementClienteCollectionView.Text = "Cliente";
            tileItemElementClienteCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
			this.tileBarItemClienteCollectionView.Elements.Add(tileItemElementClienteCollectionView);
			this.tileBarItemClienteCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.tileBarItemClienteCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarGroupTables.Items.Add(this.tileBarItemClienteCollectionView);
						
				
			// 
            // navigationFrame
            // 
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.SelectedPage = null;
            this.navigationFrame.SelectedPageIndex = -1;
            this.navigationFrame.Text = "navigationFrame";
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(CadastroDesktop.ViewModels.ContextoViewModel);
			// 
            // ContextoView
            // 
			this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "ContextoView";
			this.Text = "ContextoView";
            this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupViews;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemClienteCollectionView;
					}
}
