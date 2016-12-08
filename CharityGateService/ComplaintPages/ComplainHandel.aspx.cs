using CharityGateServiceDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharityGateService.ComplaintPages
{
    public partial class ComplainHandel : System.Web.UI.Page
    {
        CharityGateServiceModel db = new CharityGateServiceModel();
        private string _CustomerContactNumber = "";
        public string CustomerContactNumber
        {
            get
            {
                return _CustomerContactNumber;
            }
            set
            {
                _CustomerContactNumber = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["response"] != null)
                _CustomerContactNumber = Request.QueryString["response"];

            string UserSessionId = Request.Headers["User-SessionId"];
            string UserMSISDN = Request.Headers["User-MSISDN"];
            string UserTOKEN = Request.Headers["User-TOKEN"];

            var transactionobject = db.ComplaintsTransactions.Where(transaction => (transaction.UserSessionId == UserSessionId) 
                && (transaction.UserMSISDN == UserMSISDN) 
                && (transaction.UserTOKEN == UserTOKEN)).ToList().First();

            transactionobject.ComplainantContactNumber = _CustomerContactNumber;

            db.ComplaintsTransactions.AddOrUpdate(transactionobject);
            db.SaveChanges();
        }
    }
}