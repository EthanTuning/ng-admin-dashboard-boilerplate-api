
using System.Collections.Generic;

namespace ng_admin_dashboard_boilerplate_api.Models.App_Models {

    public abstract class ToolBase {

        public string Name { get; set; }

        public ToolBase(string name) {

            Name = name;

        }

    }

}