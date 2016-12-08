using CharityGateServiceDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharityGateService.RegisterationPages
{
    public partial class RegisterationSaveName : System.Web.UI.Page
    {
        CharityGateServiceModel db = new CharityGateServiceModel();
        private string _RegistrationName = "";
        public string HospitalId
        {
            get
            {
                return _RegistrationName;
            }
            set
            {
                _RegistrationName = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["response"] != null)
                _RegistrationName = Request.QueryString["response"];

            string UserSessionId = Request.Headers["User-SessionId"];
            string UserMSISDN = Request.Headers["User-MSISDN"];
            string UserTOKEN = Request.Headers["User-TOKEN"];

            var transactionobject = new RegistrationTransaction()
            {
                UserSessionId = UserSessionId,
                UserMSISDN = UserMSISDN,
                UserTOKEN = UserTOKEN,
                OrganizationContactNumber = "",
                OrganizationName = _RegistrationName,
                TransactionDate = DateTime.Now
            };

            db.RegistrationTransactions.AddOrUpdate(transactionobject);
            db.SaveChanges();
            //save it to data base
        }
    }
}