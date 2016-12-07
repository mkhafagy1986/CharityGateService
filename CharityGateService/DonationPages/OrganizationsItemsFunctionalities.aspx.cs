using CharityGateServiceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharityGateService.DonationPages
{
    public partial class OrganizationsItemsFunctionalities : System.Web.UI.Page
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

        private string _OrganizationItemName = "";
        public string OrganizationItemName
        {
            get
            {
                return _OrganizationItemName;
            }
            set
            {
                _OrganizationItemName = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["OrganizationTypeId"] != null)
                _OrganizationTypeId = Request.QueryString["OrganizationTypeId"];
            if (Request.QueryString["OrganizationItemId"] != null)
                _OrganizationItemId = Request.QueryString["OrganizationItemId"];


            int OrganizationTypeInt = -1;
            Int32.TryParse(_OrganizationTypeId, out OrganizationTypeInt);
            int _OrganizationItemIdInt = -1;
            Int32.TryParse(_OrganizationItemId, out _OrganizationItemIdInt);

            var OrganizationItem = db.OrganizationsItems.Where(item => (item.OrganizationTypeId == OrganizationTypeInt) && (item.OrganizationItemId == _OrganizationItemIdInt)).ToList().First();
            if (OrganizationItem != null)
            {
                if (System.Configuration.ConfigurationManager.AppSettings["Language"] == "Arabic")
                    _OrganizationItemName = OrganizationItem.OrganizationItemArabicName;
                else if (System.Configuration.ConfigurationManager.AppSettings["Language"] == "English")
                    _OrganizationItemName = OrganizationItem.OrganizationItemEnglishName;
            }

            OrganizationsFunctionallatyRepeater.DataSource = db.OrganizationsFunctionalities.ToList();
            OrganizationsFunctionallatyRepeater.DataBind();
        }
    }
}