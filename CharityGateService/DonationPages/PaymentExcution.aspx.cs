using CharityGateServiceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharityGateService.DonationPages
{
    public partial class PaymentExcution : System.Web.UI.Page
    {
        CharityGateServiceModel db = new CharityGateServiceModel();
        private string _ConfirmationCode;
        public string ConfirmationCode
        {
            get { return _ConfirmationCode; }
            set { _ConfirmationCode = value; }
        }

        private string _OrganizationName;
        public string OrganizationName
        {
            get { return _OrganizationName; }
            set { _OrganizationName = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["response"] != null)
                _ConfirmationCode = Request.QueryString["response"];


            string UserSessionId = Request.Headers["User-SessionId"];
            string UserMSISDN = Request.Headers["User-MSISDN"];
            string UserTOKEN = Request.Headers["User-TOKEN"];

            var transactionObject = db.Transactions.Where(
                transaction =>
                    (transaction.UserSessionId == UserSessionId) && (transaction.UserMSISDN == UserMSISDN) &&
                    (transaction.UserTOKEN == UserTOKEN)).ToList().First();

            var OrganizationObject = db.OrganizationsItems.Where(
                item =>
                    (item.OrganizationTypeId == transactionObject.OrganizationTypeId.Value) &&
                    (item.OrganizationItemId == transactionObject.OrganizationId.Value))
                .ToList()
                .First();
            if (System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic")
                _OrganizationName = OrganizationObject.OrganizationItemArabicName;
            else if (System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")
                _OrganizationName = OrganizationObject.OrganizationItemEnglishName;
            //check for user confirmation code that equal 1
            //retrive the transaction information from database and display the hospital name
            //save the final transaction and make the payment process
        }
    }
}