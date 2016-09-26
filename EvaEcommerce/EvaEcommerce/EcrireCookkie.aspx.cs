using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvaEcommerce
{
    public partial class EcrireCookkie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Nom = this.Request.Params["NomUtilisateur"];
            string Produit = this.Request.Params["NomProduit"];
            string Nombre = this.Request.Params["number"];

                HttpCookie cookie = new HttpCookie("Panier");
                cookie.Values["SessionID"] = Session.SessionID;
                cookie.Values["Nom"] = Nom;
                cookie.Values["IdProduit"] = Produit;
                cookie.Values["Quantite"] = Nombre;
                cookie.Values["DateDernierVisite"] = DateTime.Now.ToString();
                cookie.Expires = DateTime.Now.AddDays(5);

                Response.Cookies.Add(cookie);
               
            
        }
    }
}