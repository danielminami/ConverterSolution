using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UnitesWebConverterGroup_P14_1205_11181_2 {
    public partial class HomePage : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ButtonConvert_Click(object sender, EventArgs e) {
            LabelError.Visible = false;
            ServiceReferenceLength.ConverterServiceSoapClient service = new ServiceReferenceLength.ConverterServiceSoapClient();

            if (double.TryParse(TextValue.Text, out double value)) {
                if (DropDownFrom.Text != DropDownTo.Text) {
                    TextResult.Text = Convert.ToString(service.calculateLength(value, DropDownFrom.Text, DropDownTo.Text));
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