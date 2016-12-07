using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CharityGateServiceDAL;

namespace CharityGateService.DonationPages
{
    public partial class OrganizationItems : System.Web.UI.Page
    {

        CharityGateServiceModel db = new CharityGateServiceModel();
        private string _OrganizationId = "";
        public string OrganizationId
        {
            get
            {
                return _OrganizationId;
            }
            set
            {
                _OrganizationId = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["OrganizationId"] != null)
            {
                _OrganizationId = Request.QueryString["OrganizationId"];

                int OrganizationIdInt = -1;
                Int32.TryParse(_OrganizationId, out OrganizationIdInt);

                HospitalsRepeater.DataSource =
                    db.OrganizationsItems.Where(
                        organizationItem => organizationItem.OrganizationTypeId == OrganizationIdInt).ToList();
                HospitalsRepeater.DataBind();
            }
        }
    }
}