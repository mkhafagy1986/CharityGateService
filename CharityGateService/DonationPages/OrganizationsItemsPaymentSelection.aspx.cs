using CharityGateServiceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharityGateService.DonationPages
{
    public partial class OrganizationsItemsPaymentSelection : System.Web.UI.Page
    {
        CharityGateServiceModel db = new CharityGateServiceModel();
        private string _DonationAmount;
        public string DonationAmount
        {
            get { return _DonationAmount; }
            set { _DonationAmount = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["response"] != null)
                _DonationAmount = Request.QueryString["response"];


            PaymentMethodRepeater.DataSource = db.PaymentTypes.ToList();
            PaymentMethodRepeater.DataBind();
            //Get the user current session transaction from database
            //to know which hospital to donate.
        }
    }
}