using ng_admin_dashboard_boilerplate_api.Models.App_Models;
using ng_admin_dashboard_boilerplate_api.Models.Modules.Test_Module.Actions;

namespace ng_admin_dashboard_boilerplate_api.Models.Modules.Test_Module {

    public class TestModule : ModuleBase {
        
        public TestModule() : base("Test Module") {

            ActionsList.Add(new TestAction1());
            ActionCount = ActionsList.Count;
            
        }

    }

}