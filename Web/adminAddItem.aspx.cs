using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBmodel;

namespace Web {
    public partial class adminAddItem : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
         
        }

        int activeElem = -1;
        protected void elementList_SelectedIndexChanged(object sender, EventArgs e) {
            tableElem.Visible = true;
            activeElem = int.Parse(elementList.SelectedValue);
            switch (activeElem) {
                case 0: showResistor();
                    break;
                case 1: showCapasitor();
                    break;
                case 2: showCoil();
                    break;
                default: break;
            }
        }

        protected void Button1_Click(object sender, EventArgs e) {
            switch (int.Parse(elementList.SelectedValue)) {
                case 0: insertResistor();
                    break;
                case 1: insertCapasitor();
                    break;
                case 2: insertCoil();
                    break;
                default: break;
            }
        }

        private void showResistor() {
            lName.Text = "Имя резистора";
            lValue.Text = "Сопротивление (кОм)";
            lPrice.Text = "Цена (руб)";
        }

        private void showCapasitor() {
            lName.Text = "Имя конденсатора";
            lValue.Text = "Емкость (мкФ)";
            lPrice.Text = "Цена (руб)";
        }

        private void showCoil() {
            lName.Text = "Имя индуктивности";
            lValue.Text = "Индуктивность (Гн)";
            lPrice.Text = "Цена (руб)";
        }

        private void insertResistor() {
            resistor r = new resistor();
            r.id = int.Parse(tbId.Text);
            r.name = tbName.Text;
            r.resistance = float.Parse(tbValue.Text);
            r.price = decimal.Parse(tbPrice.Text);
            trpo.insertElement(r);
        }

        private void insertCapasitor() {
            capasitor c = new capasitor();
            c.id = int.Parse(tbId.Text);
            c.name = tbName.Text;
            c.resistance = float.Parse(tbValue.Text);
            c.price = decimal.Parse(tbPrice.Text);
            trpo.insertElement(c);
        }

        private void insertCoil() {
            coil c = new coil();
            c.id = int.Parse(tbId.Text);
            c.name = tbName.Text;
            c.industance = float.Parse(tbValue.Text);
            c.price = decimal.Parse(tbPrice.Text);
            trpo.insertElement(c);
        }

        protected void btnGetData_Click(object sender, EventArgs e) {
            GetData();
        }

        private void GetData() {
            gridView.DataSource = trpo.getData(int.Parse(elementList.SelectedValue)); 
            gridView.DataBind();
        }
    }
}