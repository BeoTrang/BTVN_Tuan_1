using DLL_Tinh;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website_v2
{
    public partial class api : System.Web.UI.Page
    {
        class PhanHoi
        {
            public bool ok;
            public string msg;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            PhanHoi p = new PhanHoi();
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
                p.ok = true;
                p.msg = kq;
            }
            catch (Exception ex)
            {
                kq = $"Có lỗi: " + ex.Message;
                p.ok = false;
                p.msg = kq;
            }
            finally
            {
                string json = JsonConvert.SerializeObject(p);
                this.Response.Write(json);
            }
        }
    }
}