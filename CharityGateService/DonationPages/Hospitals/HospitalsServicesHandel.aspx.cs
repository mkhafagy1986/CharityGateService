using CharityGateServiceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharityGateService.DonationPages.Hospitals
{
    public partial class HospitalsServicesHandel : System.Web.UI.Page
    {
        CharityGateServiceModel db = new CharityGateServiceModel();
        private string _HospitalId = "";
        public string HospitalId
        {
            get
            {
                return _HospitalId;
            }
            set
            {
                _HospitalId = value;
            }
        }

        private string _FunctionalityId = "";
        public string FunctionalityId
        {
            get
            {
                return _FunctionalityId;
            }
            set
            {
                _FunctionalityId = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["HospitalId"] != null)
                _HospitalId = Request.QueryString["HospitalId"];

            if (Request.QueryString["FunctionalityId"] != null)
                _FunctionalityId = Request.QueryString["FunctionalityId"];

            if (Int32.Parse(_FunctionalityId) == 1)
                FunctionalityViews.ActiveViewIndex = 0;
            else if (Int32.Parse(_FunctionalityId) == 2)
                FunctionalityViews.ActiveViewIndex = 1;
            else if (Int32.Parse(_FunctionalityId) == 3)
                FunctionalityViews.ActiveViewIndex = 2;

            string UserSessionId = Request.Headers["User-SessionId"];
            string UserMSISDN = Request.Headers["User-MSISDN"];
            string UserTOKEN = Request.Headers["User-TOKEN"];



            //save it to data base
        }
    }
}