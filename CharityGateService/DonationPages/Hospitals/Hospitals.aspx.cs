using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CharityGateServiceDAL;

namespace CharityGateService.DonationPages.Hospitals
{ 
    public partial class Hospitals : System.Web.UI.Page
    {

        CharityGateServiceModel db = new CharityGateServiceModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            HospitalsRepeater.DataSource = db.Hospitals.ToList();
            HospitalsRepeater.DataBind();
        }
    }
}