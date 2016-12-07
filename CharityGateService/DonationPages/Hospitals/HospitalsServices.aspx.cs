using CharityGateServiceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharityGateService.DonationPages.Hospitals
{
    public partial class HospitalsServices : System.Web.UI.Page
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

        private string _HospitalName = "";
        public string HospitalName
        {
            get
            {
                return _HospitalName;
            }
            set
            {
                _HospitalName = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Id"] != null)
                _HospitalId = Request.QueryString["Id"];
            int hospitalIdInt= Int32.Parse(_HospitalId);
            var hospitalObject = db.Hospitals.Where(hospital => hospital.HospitalId == hospitalIdInt).First();
            if (hospitalObject != null)
                _HospitalName = hospitalObject.HospitalName;

            HospitalsFunctionallatyRepeater.DataSource = db.HospitalFunctionalities.ToList();
            HospitalsFunctionallatyRepeater.DataBind();

            string UserSessionId = Request.Headers["User-SessionId"];
            string UserMSISDN = Request.Headers["User-MSISDN"];
            string UserTOKEN = Request.Headers["User-TOKEN"];
        }
    }
}