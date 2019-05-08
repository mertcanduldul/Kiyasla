using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using kiyas.la.Context;

namespace kiyas.la.User.Products
{
    public partial class Karsilastir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["p1"] != null && Request.QueryString["p2"] != null)
                {
                    int p1Id = int.Parse(Request.QueryString["p1"].ToString());
                    int p2Id = int.Parse(Request.QueryString["p2"].ToString());
                    using (KiyaslaContext db = new KiyaslaContext())
                    {
                        var p1 = (from i in db.SmartPhone
                                  where i.Id == p1Id
                                  select i).FirstOrDefault();
                        var p2 = (from i in db.SmartPhone
                                  where i.Id == p2Id
                                  select i).FirstOrDefault();
                        Label1.Text = p1.TelefonMarkasi;
                        Label2.Text = p2.TelefonMarkasi;
                    }

                }
            }
        }
    }
}