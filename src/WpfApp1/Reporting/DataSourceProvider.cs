using DevExpress.DataAccess.ObjectBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Reporting
{
    [DisplayName("ScenarioComparisonDataSource")]
    [HighlightedClass]
    public class DataSourceProvider
    {

        [HighlightedMember]
        public DataSourceProvider()
        {
        }

        [HighlightedMember]
        public IEnumerable<CommonData> GetCommonDataSource()
        {
            return null;
        }

        public static DataTable GetHeaderTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Translation", typeof(string));           
            table.Columns.Add("Year1", typeof(string));
            table.Columns.Add("Year2", typeof(string));
            table.Columns.Add("Year3", typeof(string));
            table.Columns.Add("Year4", typeof(string));

            table.Rows.Add("TestPerson1", "2025", "2026", "2027", "2028");
            table.Rows.Add("TestPerson2", "2025", "2026", "very  very very long", "");
            return table;

        }

        public static DataTable GetBodyTable()
        {

            DataTable table = new DataTable();
            table.Clear();
            table.Columns.Add("ScenarioDescription", typeof(string));
            table.Columns.Add("ScenarionId", typeof(int));            
            table.Columns.Add("Year1", typeof(string));
            table.Columns.Add("Year2", typeof(string));
            table.Columns.Add("Year3", typeof(string));
            table.Columns.Add("Year4", typeof(string));
            table.Columns.Add("Translation", typeof(string));

            table.Rows.Add("Category 1", 1, "1000", "2000", "3000", "4000", "TestPerson 1");
            table.Rows.Add("Category 1", 1, "2025", "2026", "Very looooooooooooooooooooong text", "", "");
            table.Rows.Add("Category 1", 1, "1000", "2000", "3000", "4000", "TestPerson 3");
            table.Rows.Add("Category 1", 1, "2025", "2026", "2027", "2027", "TestPerson 4" );

            table.Rows.Add("Category 2", 2, "1000", "2000", "3000", "4000", "TestPerson 5");
            table.Rows.Add("Category 2", 2,  "2025", "2026", "2027", "2027", "TestPerson 6");
            table.Rows.Add("Category 2", 2, "1000", "2000", "3000", "4000", "TestPerson 7");
            table.Rows.Add("Category 2", 2, "2025", "2026", "2027", "2027", "TestPerson 8");

            table.Rows.Add("Category 3", 3, "1000", "2000", "3000", "4000", "TestPerson 9");
            table.Rows.Add("Category 3", 3, "2025", "2026", "2027", "2027", "TestPerson 10");
            table.Rows.Add("Category 3", 3, "1000", "2000", "3000", "4000", "TestPerson 11");
            table.Rows.Add("Category 3", 3, "2025", "2026", "2027", "2027", "TestPerson 12");
            return table;

        }
    }
}
