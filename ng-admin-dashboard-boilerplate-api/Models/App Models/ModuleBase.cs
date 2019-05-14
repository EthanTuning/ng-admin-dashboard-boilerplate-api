using System.Collections.Generic;

namespace ng_admin_dashboard_boilerplate_api.Models.App_Models {

    public abstract class ModuleBase {

        public string Name { get; set; }
        public List<ActionBase> ActionsList { get; set; }
        public int ActionCount { get; set; }

        public ModuleBase(string name) {

            Name = name;
            ActionsList = new List<ActionBase>();
            ActionCount = ActionsList.Count;

        }

    }

}