using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBmodel;

namespace Web {
    public partial class creatingScheme : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void elementList_SelectedIndexChanged(object sender, EventArgs e) {
            elementList.Items[0].Enabled = false;
            gridView.DataSource = trpo.getData(int.Parse(elementList.SelectedValue));
            gridView.DataBind();
        }

    }
}