using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MID {
    public partial class Q1 : System.Web.UI.Page {
        string[] s_IdSet = new string[3] { "A123456789", "P123456789", "YD321" };

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void tb_Account_TextChanged(object sender, EventArgs e) {
            bool b_IsExisted = false;
            for (int i_Ct = 0; i_Ct < s_IdSet.Length; i_Ct++) {
                if ((tb_Account.Text).Equals(s_IdSet[i_Ct])) {
                    b_IsExisted = true;
                    break;
                }
            }
            lb_Type.Text = (b_IsExisted ? "複診" : "初診");
            btn_Submit.Visible = ((tb_Account.Text).Equals("") ? false : true);
            pl_Msg.Visible = false;

        }

        protected void btn_Submit_Click(object sender, EventArgs e) {
            pl_Msg.Visible = true;
            lb_Msg.Text = lb_Type.Text + "<br />" +
                tb_Account.Text + "先生/小姐，已完成掛號。" + "<br />";
            if (!(tb_Phone.Text).Equals("")) {
                lb_Msg.Text += "連絡電話為" + tb_Phone.Text + "<br />";
            }
        }

        protected void tb_Email_TextChanged(object sender, EventArgs e) {

        }
    }
}