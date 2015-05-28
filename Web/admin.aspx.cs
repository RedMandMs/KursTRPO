using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBmodel;

namespace Web {
    public partial class admin : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        public void entryAsAdmin(object sender, EventArgs e) {
            string jsString = "alert('" + "Surprise motherfucker" + "');";
            ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(),
                    "TRPO",
                    jsString,
                    true);    
        }

        protected void elementList_SelectedIndexChanged(object sender, EventArgs e) {
            GridView1.DataSource = trpo.getS(int.Parse(elementList.SelectedValue));
            GridView1.DataBind();
        }
    }
}