using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharityGateService.DonationPages.Hospitals
{
    public partial class PayByOrangeWalletHandel : System.Web.UI.Page
    {
        private string _OrangeWalletPassword;
        public string ConfirmationCode
        {
            get { return _OrangeWalletPassword; }
            set { _OrangeWalletPassword = value; }
        }

        private string _HospitalName;
        public string HospitalName
        {
            get { return _HospitalName; }
            set { _HospitalName = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["response"] != null)
                _OrangeWalletPassword = Request.QueryString["response"];


            string UserSessionId = Request.Headers["User-SessionId"];
            string UserMSISDN = Request.Headers["User-MSISDN"];
            string UserTOKEN = Request.Headers["User-TOKEN"];

            //check for customer orange wallet account by the entered password.
            //retrive the transaction information from database and display the hospital name
            //save the final transaction and make the payment process
        }
    }
}