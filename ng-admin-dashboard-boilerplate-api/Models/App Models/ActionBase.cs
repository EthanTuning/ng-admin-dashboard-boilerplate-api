
namespace ng_admin_dashboard_boilerplate_api.Models.App_Models {

    public abstract class ActionBase {

        public string Name { get; set; }

        public ActionBase(string name) {

            Name = name;

        }

    }

}