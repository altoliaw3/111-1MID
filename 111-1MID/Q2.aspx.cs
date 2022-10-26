using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MID {
    public partial class Q2 : System.Web.UI.Page {
        string[] s_City = new string[3] { "台北市", "新北市", "台中市"};
        string[,] s_Area = new string[3, 3] {
            {"中正區", "文山區", "大安區"},
            {"淡水區", "石碇區", "土城區"},
            {"西屯區", "北屯區", "東區"}
        };

        protected void Page_Load(object sender, EventArgs e) {

            if (!IsPostBack) {
                for (int i_Ct = 0; i_Ct < s_City.Length; i_Ct++) {
                    ListItem o_Item = new ListItem();
                    o_Item.Text = s_City[i_Ct];
                    o_Item.Value = s_City[i_Ct];
                    dpl_City.Items.Add(o_Item);
                }
                mt_LoadArea();
            }
        }

        private void mt_LoadArea() {
            dpl_Area.Items.Clear();
            int i_Index = dpl_City.SelectedIndex;
            for (int i_Ct = 0; i_Ct < s_Area.GetLength(1); i_Ct++) {
                ListItem o_Item = new ListItem();
                o_Item.Text = s_Area[i_Index, i_Ct];
                o_Item.Value = s_Area[i_Index, i_Ct];
                dpl_Area.Items.Add(o_Item);
            }
        }

        protected void dpl_City_SelectedIndexChanged(object sender, EventArgs e) {
            mt_LoadArea();
        }

        protected void rbl_Phone_SelectedIndexChanged(object sender, EventArgs e) {
            if (rbl_Phone.SelectedValue.Equals("無")) {
                txt_Phone.Visible = false;
            }
            else {
                txt_Phone.Visible = true;
            }
        }
    }
}