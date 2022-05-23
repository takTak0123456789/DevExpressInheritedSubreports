namespace WpfApp1.Reporting.Inherited
{
    partial class SubReportDerivedested
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
            this.ScDescrParam = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ScDescrParam
            // 
            this.ScDescrParam.Name = "ScDescrParam";
            this.ScDescrParam.Visible = false;
            // 
            // SubReportDerivedested
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.FilterString = "[ScenarioDescription] = ?ScDescrParam";
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.ScDescrParam});
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }


        #endregion

        public DevExpress.XtraReports.Parameters.Parameter ScDescrParam;
    }
}
