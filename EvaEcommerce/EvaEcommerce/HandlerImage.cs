using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace EvaEcommerce
{
    public class HandlerImage : IHttpHandler
    {

        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            int? idImage = int.Parse(context.Request["Productid"]);
            if (idImage != null)
            {
                GetImage(context.Response, (int)idImage);
            }
        }

        public void GetImage(HttpResponse reponse, int id)
        {

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5A9RHHB;Initial Catalog=EcommerceSimplifie; Integrated Security=True"))
            {
                //try
                //{
                SqlCommand command = new SqlCommand("select Picture.PictureBinary, Picture.MimeType from Picture inner join Product_Picture_Mapping on Picture.Id = Product_Picture_Mapping.PictureId where ProductId = @id and DisplayOrder = 1;");
                command.Connection = connection;
                command.Parameters.Add(new SqlParameter("@id", id));

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {


                    //type de l'image
                    string typeMime = reader.GetString(1);
                    reponse.ContentType = (string.IsNullOrEmpty(typeMime)) ? "image/jpeg" : typeMime;

                    //mise en cache
                    reponse.Cache.SetCacheability(HttpCacheability.Public);

                    int indexDepart = 0;
                    int tailleBuffer = 1024;
                    long nombreOctets = 0;
                    Byte[] flux = new Byte[1024];

                    nombreOctets = reader.GetBytes(0, indexDepart, flux, 0, tailleBuffer);

                    while (nombreOctets == tailleBuffer)
                    {
                        reponse.BinaryWrite(flux);
                        reponse.Flush();
                        indexDepart += tailleBuffer;
                        nombreOctets = reader.GetBytes(0, indexDepart, flux, 0, tailleBuffer);
                    }
                    if (nombreOctets > 0)
                    {
                        reponse.BinaryWrite(flux);
                        reponse.Flush();
                    }
                    reponse.End();


                }
                //catch(Exception)
                //{
                //    throw new Exception("Pas d'image disponible.");   
                //}
                //}
            }
        }



    }
}