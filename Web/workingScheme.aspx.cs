using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBmodel;

namespace Web {
    public partial class workingScheme : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void elementList_SelectedIndexChanged(object sender, EventArgs e) {
            elementList.Items[0].Enabled = false;
            var data = trpo.getScheme(int.Parse(elementList.SelectedValue));
            Table2.Rows.Clear();

            var hr = new TableRow();
            hr.Cells.Add(new TableCell() { Text = "Id" });
            hr.Cells.Add(new TableCell() { Text = "Name" });
            hr.Cells.Add(new TableCell() { Text = "Value" });
            hr.Cells.Add(new TableCell() { Text = "Value2" });
            hr.Cells.Add(new TableCell() { Text = "Max temp" });
            hr.Cells.Add(new TableCell() { Text = "Price" });
            Table2.Rows.Add(hr);

            for (int i = 0; i < data.Count; i++) {
			    var tr = new TableRow();   
                var tcId = new TableCell();
                var tcName = new TableCell();
                var tcValue = new TableCell();
                var tcValue2 = new TableCell();
                var tcTemp = new TableCell();
                var tcPrice = new TableCell();
                if (data[i] is resistor) {
                    tcId.Text = ((resistor)data[i]).id.ToString();
                    tcName.Text = ((resistor)data[i]).name.ToString();
                    tcValue.Text = ((resistor)data[i]).resistance.ToString();
                    tcValue2.Text = ((resistor)data[i]).max_voltage.ToString();
                    tcTemp.Text = ((resistor)data[i]).max_temp.ToString();
                    tcPrice.Text = ((resistor)data[i]).price.ToString();
                } else if (data[i] is capasitor) {
                    tcId.Text = ((capasitor)data[i]).id.ToString();
                    tcName.Text = ((capasitor)data[i]).name.ToString();
                    tcValue.Text = ((capasitor)data[i]).resistance.ToString();
                    tcValue2.Text = ((capasitor)data[i]).max_freq.ToString();
                    tcTemp.Text = ((capasitor)data[i]).max_temp.ToString();
                    tcPrice.Text = ((capasitor)data[i]).price.ToString();
                } else if (data[i] is coil) {
                    tcId.Text = ((coil)data[i]).id.ToString();
                    tcName.Text = ((coil)data[i]).name.ToString();
                    tcValue.Text = ((coil)data[i]).industance.ToString();
                    tcValue2.Text = ((coil)data[i]).max_freq.ToString();
                    tcTemp.Text = ((coil)data[i]).max_temp.ToString();
                    tcPrice.Text = ((coil)data[i]).price.ToString();
                }
                tr.Cells.Add(tcId);
                tr.Cells.Add(tcName);
                tr.Cells.Add(tcValue);
                tr.Cells.Add(tcValue2);
                tr.Cells.Add(tcTemp);
                tr.Cells.Add(tcPrice);
                Table2.Rows.Add(tr);
			}
        }
    }
}