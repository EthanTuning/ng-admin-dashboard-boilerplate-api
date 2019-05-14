using ng_admin_dashboard_boilerplate_api.Models.App_Models;
using ng_admin_dashboard_boilerplate_api.Models.Reports.Test_Report;
using System.Collections.Generic;

namespace ng_admin_dashboard_boilerplate_api.Models.Tools {

    public class ReportsTool : ToolBase {

        public List<ReportBase> ReportsList { get; set; }
        public int ReportsCount { get; set; }

        public ReportsTool() : base("Reports") {

            ReportsList = new List<ReportBase>();
            ReportsList.Add(new TestReport1());
            ReportsCount = ReportsList.Count;

        }

    }

}