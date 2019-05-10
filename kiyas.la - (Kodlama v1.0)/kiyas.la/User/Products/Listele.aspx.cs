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
                    //girilen id'de ürün var
                }
                else
                {
                    //id değeri yok
                    //tüm ürünleri yükle
                    LoadProducts();
                    randomdate();


                }
                using (KiyaslaContext db = new KiyaslaContext())
                {
                    Product1.DataSource = db.SmartPhone.ToList();
                    Product1.DataTextField = "MarkaModel";
                    Product1.DataValueField = "Id";
                    Product1.DataBind();

                    Product2.DataSource = db.SmartPhone.ToList();
                    Product2.DataTextField = "MarkaModel";
                    Product2.DataValueField = "Id";
                    Product2.DataBind();
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
                sliderListview.DataSource = (from i in db.SmartPhone
                                             where i.Id  > 8
                                             select i).ToList();
                sliderListview.DataBind();
            }
        }

        private void LoadProducts()
        {
            using (KiyaslaContext db = new KiyaslaContext())
            {
                ListView1.DataSource = db.SmartPhone.ToList();
                ListView1.DataBind();
                sliderListview.DataSource = (from i in db.SmartPhone
                                             where i.Id > 8
                                             select i).ToList();
                sliderListview.DataBind();
            }
        }
        protected string randomdate()
        {


            Random r = new Random();
            return r.Next(1, 31).ToString();

            
        }



        protected void BtnKarsilastir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Karsilastir?p1=" + Product1.SelectedValue.ToString() + "&p2=" + Product2.SelectedValue.ToString());
        }
    }
}