using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Laborator_A2_3
{
    public static class Tokens
    {

     //   public int IdUseri = Convert.ToInt32(Session["userId"].ToString());
        public static int IdUseri = 2;

        // therret bazen e te dhenave
        // select * from t_Azuthorization where id_useri = IdUseri

        public static List<Authorization> Authorizations { get; set; } = new List<Authorization>();

     

        public static List<Authorization> GetAuthorizationsFromDb()
        {
            // sqlconnection
            DataTable dt = new DataTable();
            foreach( DataRow row in dt.Rows)
            {
                var item = new Authorization();

                item.AuthorizationDescription = row["AuthorizationDescription"].ToString();
                Authorizations.Add(item);
            }
           // dt.AsEnumerable().Select(i=>i.)
            return Authorizations;
        }

    }


    public class Authorization {
    
    
        public int IdAuthorization { get; set; }
        public string AuthorizationDescription { get; set; }
        public bool ForAdmin { get; set; }

    }

}