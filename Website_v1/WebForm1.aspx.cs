using DLL_Tinh;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website_v1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n, dem = 0;
                n = int.Parse(TextBox1.Text);
                Tinh tinh = new Tinh();
                tinh.n = n;
                tinh.Uoc();
                dem = tinh.dem;
                KetQua.InnerHtml = $"Kết quả: "+dem + "</a>";
            }
            catch (Exception ex)
            {
                KetQua.InnerHtml = $"Có lỗi: "+ex.Message;
            }
        }
    }
}