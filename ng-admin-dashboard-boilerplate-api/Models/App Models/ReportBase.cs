
namespace ng_admin_dashboard_boilerplate_api.Models.App_Models {

    public abstract class ReportBase {

        public string Name { get; set; }

        public ReportBase(string name) {

            Name = name;

        }

    }

}