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
using System.Web.UI.HtmlControls;

namespace EvaEcommerce
{
    public partial class LireCookie : System.Web.UI.Page
    {
        private DataSetEcommerce DS;
        private ProductTableAdapter PTA;
        protected void Page_Load(object sender, EventArgs e)
        {
            Panier();
           
        }

        public void Panier()
        {
            if (Request.Cookies["Panier"] != null)
            {
                string IdProduit = Server.HtmlEncode(Request.Cookies["Panier"]["IdProduit"]);
                string NomUtilisateur = Server.HtmlEncode(Request.Cookies["Panier"]["Nom"]);
                string Quantite = Server.HtmlEncode(Request.Cookies["Panier"]["Quantite"]);


                DS = new DataSetEcommerce();
                DS.EnforceConstraints = false;
                PTA = new ProductTableAdapter();

                PTA.FillByPanier(DS.Product, Int32.Parse(IdProduit));

                header.InnerHtml = "Bonjour " + NomUtilisateur;

                StringBuilder SBTable = new StringBuilder();

                foreach (DataSetEcommerce.ProductRow item in DS.Product)
                {
                    int q = Int32.Parse(Quantite);

                    if(q < item.OrderMaximumQuantity)
                    {
                        if(q >= item.OrderMinimumQuantity)
                        {
                            if(q <= item.StockQuantity)
                            {
                                SBTable.AppendFormat("<td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td>", item.Id, item.Name, item.ShortDescription, item.Weight, item.Length, item.Width, item.Height, item.Price);

                            }
                        }
                    }
                 }

                    tablePanier.Rows.Add(new  HtmlTableRow()
            }
        }


    }
}