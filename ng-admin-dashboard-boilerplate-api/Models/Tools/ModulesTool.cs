using ng_admin_dashboard_boilerplate_api.Models.App_Models;
using ng_admin_dashboard_boilerplate_api.Models.Modules.Test_Module;
using System.Collections.Generic;

namespace ng_admin_dashboard_boilerplate_api.Models.Tools {

    public class ModulesTool : ToolBase {

        public List<ModuleBase> ModulesList { get; set; }
        public int ModulesCount { get; set; }

        public ModulesTool() : base("Modules") {

            ModulesList = new List<ModuleBase>();
            ModulesList.Add(new TestModule());
            ModulesCount = ModulesList.Count;

        }

    }

}