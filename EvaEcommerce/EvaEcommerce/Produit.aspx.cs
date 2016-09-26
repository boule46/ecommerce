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
    public partial class Produit : System.Web.UI.Page
    {
        private DataSetEcommerce DS;
        private ProductTableAdapter PTA;
        private Product_Picture_MappingTableAdapter PICTA;
        protected void Page_Load(object sender, EventArgs e)
        {
            AfficherCategorie();




        }

        public void AfficherCategorie()
        {
            var CategorieID = this.Request.Params["categoryId"];
            

            DS = new DataSetEcommerce();
            DS.EnforceConstraints = false;
            PTA = new ProductTableAdapter();
           
           PTA.FillByCategoryID(DS.Product, Convert.ToInt32(CategorieID));
    
            StringBuilder SBproduct = new StringBuilder();

            foreach (DataSetEcommerce.ProductRow item in DS.Product)
            {
                PICTA = new Product_Picture_MappingTableAdapter();
                int PictureID1 = PICTA.FillByGetPictureID(DS.Product_Picture_Mapping, item.Id);

                SBproduct.AppendFormat("<section><h1>{0} (Réf: {1})</h1><img src=\"a.imgg?Productid={1}\" alt=\"image du produit {0}\" height=\"150\" width=\"250\"><p>{2}</p><p><input type=\"button\" class=\"btn btn-info\" onclick='RequeteAjax({1})' value=\"Plus d'information\" /><p id=\"fullDescriptionProduit\"></p><p>Prix: {3}<button type=\"button\" class=\"btn btn-success\" onclick='RequeteAjaxPanier({1})'><span class=\"glyphicon glyphicon-shopping-cart\" aria-hidden=\"true\"></span> Dans mon panier</button></p></section><hr/>", item.Name, item.Id, item.ShortDescription, item.Price);
            }


            ProduitsAff.InnerHtml = SBproduct.ToString();


        }

       
    }
}