using CharityGateServiceDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharityGateService.DonationPages
{
    public partial class PaymentMethodHandel : System.Web.UI.Page
    {
        CharityGateServiceModel db = new CharityGateServiceModel();
        private string _DonationAmount;
        public string DonationAmount
        {
            get { return _DonationAmount; }
            set { _DonationAmount = value; }
        }

        private string _PaymentTypeId;
        public string PaymentTypeId
        {
            get { return _PaymentTypeId; }
            set { _PaymentTypeId = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["donationamount"] != null)
                _DonationAmount = Request.QueryString["donationamount"];

            if (Request.QueryString["PaymentTypeId"] != null)
                _PaymentTypeId = Request.QueryString["PaymentTypeId"];

            string UserSessionId = Request.Headers["User-SessionId"];
            string UserMSISDN = Request.Headers["User-MSISDN"];
            string UserTOKEN = Request.Headers["User-TOKEN"];

            var transactionObject = db.Transactions.Where(
                transaction =>
                    (transaction.UserSessionId == UserSessionId) && (transaction.UserMSISDN == UserMSISDN) &&
                    (transaction.UserTOKEN == UserTOKEN)).ToList().First();


            if (transactionObject != null)
            {
                var paymentTransaction = new PaymentTransaction()
                {
                    PaymentAmount = decimal.Parse(_DonationAmount),
                    PaymentDate = DateTime.Now,
                    PaymentTypeId = Int32.Parse(_PaymentTypeId),
                    TransactionId = transactionObject.TransactionId,
                    PaymentStatus = (int)PaymentStatusEnum.Initiated
                };
                db.PaymentTransactions.AddOrUpdate(paymentTransaction);
                db.SaveChanges();
            }

            //Get the user current session transaction from database
            //to know which hospital to donate.
        }
        
    }
}