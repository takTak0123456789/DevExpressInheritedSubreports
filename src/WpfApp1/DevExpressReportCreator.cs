using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Reporting;
using WpfApp1.Reporting.Inherited;

namespace WpfApp1
{
    public static class DevExpressReportCreator
    {
        public static XtraReport GetReport(List<DataTable> dataList, string programCode)
        {
            var report = GetReportFile(programCode);

            if (report == null)
            {
                return null;
            }

            var dataMember = report.DataMember;
            report.DataSource = dataList[0];
            report.DataMember = dataMember;

            var sortedSubreports = report.AllControls<XRSubreport>().OrderBy(x => x.Name).ToList();

            for (var i = 0; i < sortedSubreports.Count; i++)
            {
                var subreport = sortedSubreports[i];

                //if (subreport.ReportSource != null)
                //{


                //}

                if (dataList.Count > i + 1)
                {
                    subreport.ReportSource.DataSource = new ObjectDataSource();
                    XtraReport reportSource = subreport.ReportSource;

                    (reportSource.DataSource as ObjectDataSource).DataSource = dataList[i + 1];
                    reportSource.DataMember = "";
                }

                else
                {
                    subreport.ReportSource.DataSource = new ObjectDataSource();
                    XtraReport reportSource = subreport.ReportSource;

                    (reportSource.DataSource as ObjectDataSource).DataSource = dataList[0];
                    reportSource.DataMember = "";
                }
            }

            report.CreateDocument();
            return report;
        }

        private static XtraReport GetReportFile(string programCode)
        {
            switch (programCode)
            {
                case "Test1":
                    //return new SimpleReport();
                    return new ReportInherited();
                    


                default:
                    return null;
            }
        }
    }
}
