using System;
using System.Collections.Generic;
using System.Data;

namespace Segundo_Parcial_POO
{
    public static class BusinessDAO
    {
        public static List<Business> getBusinesses()
                {
                    string query = $"SELECT * FROM BUSINESS";
        
                    DataTable dt = DBConnection.ExecuteQuery(query);
        
                    List<Business> list = new List<Business>();
                    foreach (DataRow row in dt.Rows)
                    {
                        Business bu = new Business();
                        bu.idBusiness = Convert.ToInt32(row[0].ToString());
                        bu.name = row[1].ToString();
                        bu.description = row[2].ToString();
                        list.Add(bu);
                    }
                    return list;
                }
                
        public static void InsertBusiness(Business newB)
        {

            string query = $"INSERT INTO BUSINESS(name, description) VALUES ('{newB.name}', '{newB.description}');";
                DBConnection.ExecuteNonQuery(query);
        }

        public static void DeleteBusiness(Business bs)
        {
            string query = $"DELETE FROM BUSINESS WHERE idBusiness = {bs.idBusiness};";
            DBConnection.ExecuteNonQuery(query);
        }
        
        public static DataTable GetColumns()
        {
            String query = $"SELECT b.name AS \"Negocio\", sum(cp.cant) AS \"Total pedidos\"" +
                           " FROM BUSINESS b,"  +
                           " (SELECT p.idBusiness, p.name, count(ap.idProduct) AS \"cant\" "+
                           " FROM PRODUCT p, APPORDER ap " +
                           "WHERE p.idProduct = ap.idProduct" +
                           " GROUP BY p.idProduct " +
                           "ORDER BY p.name ASC) AS cp" +
                           " WHERE b.idBusiness = cp.idBusiness" +
                           " GROUP BY b.idBusiness;";
            return DBConnection.ExecuteQuery(query);
        }
    }
    
    
}
    
    