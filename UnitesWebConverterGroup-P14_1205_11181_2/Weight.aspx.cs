using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UnitesWebConverterGroup_P14_1205_11181_2 {
    public partial class Weight : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ButtonConvert_Click(object sender, EventArgs e) {
            LabelError.Visible = false;
            ServiceReferenceWeight.Weight1SoapClient service = new ServiceReferenceWeight.Weight1SoapClient();

            if (double.TryParse(TextValue.Text, out double value)) {
                if (DropDownFrom.Text != DropDownTo.Text) {
                    TextResult.Text = Convert.ToString(service.calculateWeight(value, DropDownFrom.Text, DropDownTo.Text));
                } else {
                    LabelError.Text = "Error: Units cannot be the same.";
                    LabelError.Visible = true;
                }
            } else {
                LabelError.Text = "Error: Value must be a number.";
                LabelError.Visible = true;
            }
        }
    }
}