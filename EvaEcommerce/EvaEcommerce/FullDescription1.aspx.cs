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
    public partial class FullDescription1 : System.Web.UI.Page
    {
        private DataSetEcommerce DS;
        private ProductTableAdapter PTA;
        private CategoryTableAdapter CTA;

        protected void Page_Load(object sender, EventArgs e)
        {
            AfficherFullDescription();

       }

        public void AfficherFullDescription()
        {
            var ProductID = this.Request.Params["id"];

            DS = new DataSetEcommerce();
            DS.EnforceConstraints = false;
            PTA = new ProductTableAdapter();

            PTA.FillByFullDescription(DS.Product, Convert.ToInt32(ProductID));

            StringBuilder SBFullDes = new StringBuilder();

            foreach (DataSetEcommerce.ProductRow item in DS.Product)
            {
                SBFullDes.Append(item.FullDescription);
            }


            Response.Clear();
            Response.ContentType = "application/x-www-form-urlencoded";
            Response.Write(SBFullDes.ToString());
            Response.End();
        }






    }
}