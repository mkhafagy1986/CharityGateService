﻿using CharityGateServiceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharityGateService
{
    public partial class Default : System.Web.UI.Page
    {
        CharityGateServiceModel db = new CharityGateServiceModel();
        protected void Page_Load(object sender, EventArgs e)
        {

            ServiceFunctionalitiesRepeater.DataSource = db.ServiceFunctionalities.ToList();
            ServiceFunctionalitiesRepeater.DataBind();
            //MembershipCreateStatus userStatus;
            //Membership.CreateUser("OrangeUser", "OrangePass", "a@a.com", "what is your name?", "Orange", true, out userStatus);

            //Membership.CreateUser("mostafa.khafagy", "BIP@ssw0rd", "a@a.com", "what is your name?", "mostafa"WE', true, out userStatus);
        }
    }
}