﻿namespace WpfApp1.Reporting.Inherited
{
    partial class ReportInherited
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
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // xrSubreport2
            // 
            this.xrSubreport2.CanShrink = true;
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ScDescrParam", null, "ScenarioDescription"));
            this.xrSubreport2.ReportSource = new WpfApp1.Reporting.Inherited.SubReportDerivedested();
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.ReportSource = new WpfApp1.Reporting.BaseSubreportWithDataSource();
            // 
            // ReportInherited
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportHeader,
            this.GroupHeader1});
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion


    }
}
