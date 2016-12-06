﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharityGateService.DonationPages.Hospitals
{
    public partial class PayByMobileBalance : System.Web.UI.Page
    {
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


            string UserSessionId = Request.Headers["User-SessionId"];
            string UserMSISDN = Request.Headers["User-MSISDN"];
            string UserTOKEN = Request.Headers["User-TOKEN"];
        }

        //save the donation amount in customer transactions and payment method "Mobile Balance"
    }
}