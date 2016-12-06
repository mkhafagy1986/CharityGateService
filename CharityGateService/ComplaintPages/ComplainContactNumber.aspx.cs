using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharityGateService.ComplaintPages
{
    public partial class ComplainContactNumber : System.Web.UI.Page
    {
        CharityGateServiceModel db = new CharityGateServiceModel();
        private string _complaintype = "";
        public string complaintype
        {
            get
            {
                return _complaintype;
            }
            set
            {
                _complaintype = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["complaintype"] != null)
                _complaintype = Request.QueryString["complaintype"];

            string UserSessionId = Request.Headers["User-SessionId"];
            string UserMSISDN = Request.Headers["User-MSISDN"];
            string UserTOKEN = Request.Headers["User-TOKEN"];

            // save the customer complain type
        }
    }
}