using ng_admin_dashboard_boilerplate_api.Models.App_Models;
using ng_admin_dashboard_boilerplate_api.Models.Tools;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace ng_admin_dashboard_boilerplate_api.Controllers {

    public class AppController : ApiController {

        private List<ToolBase> ToolsList;
        private int ToolsCount;

        private void initializeController() {

            ToolsList = new List<ToolBase>();

            ToolsList.Add(new ModulesTool());
            ToolsList.Add(new ReportsTool());
            ToolsCount = ToolsList.Count;

        }

        [HttpGet]
        [Route("api/app/tools/list")]
        public async Task<List<ToolBase>> GetTools() {

            var request = await Request.Content.ReadAsStreamAsync();
            initializeController();

            return ToolsList;

        }

        [HttpGet]
        [Route("api/app/tools/count")]
        public async Task<int> GetToolsCount() {

            var request = await Request.Content.ReadAsStreamAsync();
            initializeController();

            return ToolsCount;

        }

        [HttpGet]
        [Route("api/app/modules/list")]
        public async Task<List<ModuleBase>> GetModulesList() {

            var request = await Request.Content.ReadAsStreamAsync();
            initializeController();

            ModulesTool moduleTool = (ModulesTool)ToolsList.Find(item => item.Name == "Modules");

            return moduleTool.ModulesList;

        }

        [HttpGet]
        [Route("api/app/modules/count")]
        public async Task<int> GetModulesCount() {

            var request = await Request.Content.ReadAsStreamAsync();
            initializeController();

            ModulesTool modulesTool = (ModulesTool)ToolsList.Find(item => item.Name == "Modules");

            return modulesTool.ModulesCount;

        }

        [HttpGet]
        [Route("api/app/reports/list")]
        public async Task<List<ReportBase>> GetReportsList() {

            var request = await Request.Content.ReadAsStreamAsync();
            initializeController();

            ReportsTool reportsTool = (ReportsTool)ToolsList.Find(item => item.Name == "Reports");

            return reportsTool.ReportsList;

        }

        [HttpGet]
        [Route("api/app/reports/count")]
        public async Task<int> GetReportsCount() {

            var request = await Request.Content.ReadAsStreamAsync();
            initializeController();

            ReportsTool reportsTool = (ReportsTool)ToolsList.Find(item => item.Name == "Reports");

            return reportsTool.ReportsCount;

        }

    }

}