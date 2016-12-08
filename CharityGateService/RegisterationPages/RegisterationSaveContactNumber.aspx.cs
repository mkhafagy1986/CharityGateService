using CharityGateServiceDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity.Migrations;

namespace CharityGateService.RegisterationPages
{
    public partial class RegisterationSaveContactNumber : System.Web.UI.Page
    {
        CharityGateServiceModel db = new CharityGateServiceModel();
        private string _RegistrationNumber = "";
        public string RegistrationNumber
        {
            get
            {
                return _RegistrationNumber;
            }
            set
            {
                _RegistrationNumber = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["response"] != null)
                _RegistrationNumber = Request.QueryString["response"];

            string UserSessionId = Request.Headers["User-SessionId"];
            string UserMSISDN = Request.Headers["User-MSISDN"];
            string UserTOKEN = Request.Headers["User-TOKEN"];

            var transactionobject = db.RegistrationTransactions.Where(transaction => (transaction.UserSessionId == UserSessionId)
               && (transaction.UserMSISDN == UserMSISDN)
               && (transaction.UserTOKEN == UserTOKEN)).ToList().First();

            transactionobject.OrganizationContactNumber = _RegistrationNumber;

            db.RegistrationTransactions.AddOrUpdate(transactionobject);
            db.SaveChanges();
            //update the registration record that saved before
        }
    }
}