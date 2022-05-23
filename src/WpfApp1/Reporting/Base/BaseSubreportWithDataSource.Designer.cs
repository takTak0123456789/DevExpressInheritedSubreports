
namespace WpfApp1.Reporting
{
    partial class BaseSubreportWithDataSource
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 58.42F;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3});
            this.xrPanel1.SizeF = new System.Drawing.SizeF(2424F, 45F);
            this.xrPanel1.Controls.SetChildIndex(this.xrLabel3, 0);
            this.xrPanel1.Controls.SetChildIndex(this.xrLabel4, 0);
            this.xrPanel1.Controls.SetChildIndex(this.xrLabel5, 0);
            this.xrPanel1.Controls.SetChildIndex(this.xrLabel6, 0);
            this.xrPanel1.Controls.SetChildIndex(this.xrLabel7, 0);
            this.xrPanel1.Controls.SetChildIndex(this.xrLabel8, 0);
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataMember = "GetCommonDataSource";
            this.objectDataSource1.DataSource = typeof(WpfApp1.Reporting.DataSourceProvider);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Translation]")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(60.00002F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(388.7333F, 45F);
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrLabel4
            // 
            this.xrLabel4.AutoWidth = true;
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Year1]")});
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(448.7333F, 0F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(285.0167F, 45F);
            this.xrLabel4.Text = "xrLabel3";
            this.xrLabel4.WordWrap = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.AutoWidth = true;
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Year2]")});
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(733.7501F, 0F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(285.0167F, 45F);
            this.xrLabel5.Text = "xrLabel3";
            this.xrLabel5.WordWrap = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.AutoWidth = true;
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Year3]")});
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(1018.767F, 0F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(285.0167F, 45F);
            this.xrLabel6.Text = "xrLabel3";
            this.xrLabel6.WordWrap = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.AutoWidth = true;
            this.xrLabel7.Dpi = 254F;
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Year4]")});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(1303.783F, 0F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(285.0167F, 45F);
            this.xrLabel7.Text = "xrLabel3";
            this.xrLabel7.WordWrap = false;
            // 
            // xrLabel8
            // 
            this.xrLabel8.AutoWidth = true;
            this.xrLabel8.Dpi = 254F;
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Year5]")});
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(1588.8F, 0F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(285.0167F, 45F);
            this.xrLabel8.Text = "xrLabel3";
            this.xrLabel8.WordWrap = false;
            // 
            // BaseSubreportWithDataSource
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.PageWidth = 2424;
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }


        #endregion

        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        public DevExpress.XtraReports.UI.XRLabel xrLabel8;
        public DevExpress.XtraReports.UI.XRLabel xrLabel7;
        public DevExpress.XtraReports.UI.XRLabel xrLabel6;
        public DevExpress.XtraReports.UI.XRLabel xrLabel5;
        public DevExpress.XtraReports.UI.XRLabel xrLabel4;
        public DevExpress.XtraReports.UI.XRLabel xrLabel3;
    }
}
