using CharityGateServiceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharityGateService.DonationPages
{
    public partial class Donation : System.Web.UI.Page
    {
        CharityGateServiceModel db = new CharityGateServiceModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            OrganizationsRepeater.DataSource = db.OrganizationsTypes.ToList();
            OrganizationsRepeater.DataBind();
        }
    }
}