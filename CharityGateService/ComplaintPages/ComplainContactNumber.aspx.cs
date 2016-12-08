using CharityGateServiceDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity.Migrations;

namespace CharityGateService.ComplaintPages
{
    public partial class ComplainContactNumber : System.Web.UI.Page
    {
        CharityGateServiceModel db = new CharityGateServiceModel();
        private string _complaintypeId = "";
        public string complaintypeId
        {
            get
            {
                return _complaintypeId;
            }
            set
            {
                _complaintypeId = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["complaintype"] != null)
                _complaintypeId = Request.QueryString["complaintype"];

            int ComplaintypeIdInt = -1;
            Int32.TryParse(_complaintypeId, out ComplaintypeIdInt);

            string UserSessionId = Request.Headers["User-SessionId"];
            string UserMSISDN = Request.Headers["User-MSISDN"];
            string UserTOKEN = Request.Headers["User-TOKEN"];

            var transactionobject = new ComplaintsTransaction()
            {
                UserSessionId = UserSessionId,
                UserMSISDN = UserMSISDN,
                UserTOKEN = UserTOKEN,
                ComplaintTypeId = ComplaintypeIdInt,
                ComplainantContactNumber = "",
                TransactionDate = DateTime.Now
            };

            db.ComplaintsTransactions.AddOrUpdate(transactionobject);
            db.SaveChanges();

            // save the customer complain type
        }
    }
}