using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftwareEngineeringProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
            {
                String temp = DropDownList_Starting_Location.Text;
                String temp2 = DropDownList_Ending_Location.Text;
                TextBox_Directions.Text = temp + "\n" + temp2;
            }
        }

        protected void Button_Get_Directions_Click(object sender, EventArgs e)
        {
            //Server.Transfer("Default.aspx");
            Response.Redirect("Default.aspx");
        }
    }
}