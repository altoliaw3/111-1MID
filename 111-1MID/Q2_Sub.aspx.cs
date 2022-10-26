using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MID {
    public partial class Q2_Sub : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            lb_Msg.Text =
                "保單號碼: &nbsp;" + Request.Form.Get("tb_Num") + "<br />" +
                "通訊種類: &nbsp;" + Request.Form.Get("rbl_Phone") + "<br />";

            if (!Request.Form.Get("rbl_Phone").Equals("無")) {
                lb_Msg.Text +=  "通訊號碼: &nbsp;" + Request.Form.Get("txt_Phone") + "<br />";
            }
            
            lb_Msg.Text +=
                "所在城市: &nbsp;" + Request.Form.Get("dpl_City") + "<br />" +
                "所在區域: &nbsp;" + Request.Form.Get("dpl_Area") + "<br />";
        }
    }
}