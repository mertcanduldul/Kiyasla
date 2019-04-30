using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using kiyas.la.Context;

namespace kiyas.la.User.Products
{
    public partial class Listele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"].ToString());
                    LoadProductsById(id);
                    //gerçekten link içinde id isminde bir deger vardır...
                }
                else
                {
                    //id değeri yok
                    LoadProducts();
                }

            }
        }
        private void LoadProductsById(int id)
        {
            using (KiyaslaContext db = new KiyaslaContext())
            {
                ListView1.DataSource = (from i in db.SmartPhone
                                        where i.Id == id
                                        select i).ToList();
                ListView1.DataBind();
            }
        }

        private void LoadProducts()
        {
            using (KiyaslaContext db = new KiyaslaContext())
            {
                ListView1.DataSource = db.SmartPhone.ToList();
                ListView1.DataBind();
            }
        }
    }
}