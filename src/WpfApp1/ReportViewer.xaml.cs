using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.XtraReports.UI;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ReportViewer.xaml
    /// </summary>


    public partial class ReportViewer : UserControl
    {
        public static readonly DependencyProperty ReportDataProperty =
            DependencyProperty.Register("ReportData", typeof(List<DataTable>), typeof(ReportViewer), new PropertyMetadata(ReportDataChanged));


        public static readonly DependencyProperty XtraReportProperty =
    DependencyProperty.Register("XtraReport", typeof(XtraReport), typeof(ReportViewer), new PropertyMetadata(null));


        private bool displayToolbar = true;

        //public ReportViewerDevExpress()
        //{
        //    InitializeComponent();
        //}

        public ReportViewer()
        {
            InitializeComponent();
            //this.DataContext = new ReportViewerDevExpressViewModel();
            
            
            var dts = new List<DataTable>();            
            dts.Add(WpfApp1.Reporting.DataSourceProvider.GetBodyTable());
            dts.Add(WpfApp1.Reporting.DataSourceProvider.GetHeaderTable());
            ReportData = dts;
        }

        public List<DataTable> ReportData
        {
            get
            {
                return (List<DataTable>)GetValue(ReportDataProperty);
            }

            set
            {
                SetValue(ReportDataProperty, value);
                //UpdateReport();
            }
        }



        public XtraReport XtraReport
        {
            get { return (XtraReport)GetValue(XtraReportProperty); }
            set
            {
                if (XtraReport != value)
                {
                    SetValue(XtraReportProperty, value);
                    //SetReportDataSource();
                }


            }
        }



        public void UpdateReport()
        {
            //reportsViewer.DocumentSource = null;

            if (ReportData == null || ReportData.Any() == false)
            {
                return;
            }
            SetReportDataSource();

            
        }

        private XtraReport SetReportDataSource()
        {
            DevExpress.XtraReports.UI.XtraReport report = null;
            report = DevExpressReportCreator.GetReport(ReportData, "Test1");

            if (report != null)
            {
                reportsViewer.DocumentSource = report;
                report.CreateDocument(true);
                return report;
            }
            else
            {
                throw new ArgumentException($"No report found");
            }


        }

        private static void ReportDataChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var c = d as ReportViewer;
            c.UpdateReport();
        }
    }
}
