using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EvaEcommerce.DataSetEcommerceTableAdapters;
using System.Text;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Data;

namespace EvaEcommerce
{
    public partial class PanierTemp2 : System.Web.UI.Page
    {
        private DataSetEcommerce DS;
        private ProductTableAdapter PTA;
        protected void Page_Load(object sender, EventArgs e)
        {
            var id = this.Request.Params["idPN"];

            DS = new DataSetEcommerce();
            DS.EnforceConstraints = false;
            PTA = new ProductTableAdapter();

            PTA.FillByProductID(DS.Product, Int32.Parse(id));

            StringBuilder SB = new StringBuilder();

            foreach (DataSetEcommerce.ProductRow item in DS.Product)
            {
                SB.AppendFormat(item.Id.ToString());
            }

            Response.Clear();
            Response.ContentType = "application/x-www-form-urlencoded";
            Response.Write(SB.ToString());
            Response.End();


           







            

         }
    }
}