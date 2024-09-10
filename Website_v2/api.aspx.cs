using DLL_Tinh;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website_v2
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string kq = "";
            try
            {
                int n, dem = 0;
                n = int.Parse(this.Request.Form["n"]);
                Tinh tinh = new Tinh();
                tinh.n = n;
                tinh.Uoc();
                dem = tinh.dem;
                kq = $"Kết quả: " + dem + "</a>";
            }
            catch (Exception ex)
            {
                kq = $"Có lỗi: " + ex.Message;
            }
            this.Response.Write(kq);
        }
    }
}