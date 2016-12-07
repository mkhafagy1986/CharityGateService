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
    public partial class OrganizationsItemsServicesHandel : System.Web.UI.Page
    {
        CharityGateServiceModel db = new CharityGateServiceModel();
        private string _OrganizationTypeId = "";
        public string OrganizationTypeId
        {
            get
            {
                return _OrganizationTypeId;
            }
            set
            {
                _OrganizationTypeId = value;
            }
        }

        private string _OrganizationItemId = "";
        public string OrganizationItemId
        {
            get
            {
                return _OrganizationItemId;
            }
            set
            {
                _OrganizationItemId = value;
            }
        }

        private string _FunctionalityId = "";
        public string FunctionalityId
        {
            get
            {
                return _FunctionalityId;
            }
            set
            {
                _FunctionalityId = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["OrganizationTypeId"] != null)
                _OrganizationTypeId = Request.QueryString["OrganizationTypeId"];
            if (Request.QueryString["OrganizationItemId"] != null)
                _OrganizationItemId = Request.QueryString["OrganizationItemId"];


            if (Request.QueryString["FunctionalityId"] != null)
                _FunctionalityId = Request.QueryString["FunctionalityId"];

            int OrganizationTypeInt = -1;
            Int32.TryParse(_OrganizationTypeId, out OrganizationTypeInt);
            int OrganizationItemIdInt = -1;
            Int32.TryParse(_OrganizationItemId, out OrganizationItemIdInt);
            int FunctionalityIdInt = -1;
            Int32.TryParse(_FunctionalityId, out FunctionalityIdInt);


            if (FunctionalityIdInt == 1)
                FunctionalityViews.ActiveViewIndex = 0;
            else if (FunctionalityIdInt == 2)
                FunctionalityViews.ActiveViewIndex = 1;
            else if (FunctionalityIdInt == 3)
                FunctionalityViews.ActiveViewIndex = 2;

            string UserSessionId = Request.Headers["User-SessionId"];
            string UserMSISDN = Request.Headers["User-MSISDN"];
            string UserTOKEN = Request.Headers["User-TOKEN"];

            var transactionobject = new Transaction()
            {
                FunctionalityId = FunctionalityIdInt,
                OrganizationId = OrganizationItemIdInt,
                OrganizationTypeId = OrganizationTypeInt,
                TransactionDate = DateTime.Now
            };

            db.Transactions.AddOrUpdate(transactionobject);
            db.SaveChanges();
            //save it to data base
        }
    }
}