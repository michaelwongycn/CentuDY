using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setGenderDropDown();
            }
        }

        public void setGenderDropDown()
        {
            genderDropDown.Items.Add("Select gender");
            genderDropDown.Items.Add("Male");
            genderDropDown.Items.Add("Female");
        }
    }
}