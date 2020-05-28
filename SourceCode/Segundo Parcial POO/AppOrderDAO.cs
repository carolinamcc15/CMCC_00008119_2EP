using System;
using System.Collections.Generic;
using System.Data;

namespace Segundo_Parcial_POO
{
    public static class AppOrderDAO
    {

        public static DataTable ViewOrders()
        {
            string query = $"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address FROM APPORDER ao, " +
                           $"ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct " +
                           $"AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser;";
            
            DataTable dataT = DBConnection.ExecuteQuery(query);
            return dataT;
        }
        
        

        public static DataTable ViewUserOrders(AppUser user)
        {
            string query = $"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                           $"FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct " +
                           $"AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser  AND au.idUser = {user.idUser}";
            DataTable dataT = DBConnection.ExecuteQuery(query);
            return dataT;
        }

        public static void InsertOrder(Adress ad, Product pro)
        {
            string query = $"INSERT INTO APPORDER(createDate, idProduct, idAddress) " +
                           $"VALUES('{DateTime.Now}', {pro.idProduct}, {ad.idAdress});";
            DBConnection.ExecuteNonQuery(query);
        }

        public static void DeleteOrder(int idOrder)
        {
            
            string query = $"DELETE FROM APPORDER WHERE idOrder = {idOrder};";
            DBConnection.ExecuteNonQuery(query);
        }
        
        public static List<AppOrder> getAppOrders()
        {
            string query = $"SELECT * FROM APPORDER";

            DataTable dt = DBConnection.ExecuteQuery(query);

            List<AppOrder> lista = new List<AppOrder>();
            foreach (DataRow row in dt.Rows)
            {
                AppOrder ord = new AppOrder();
                ord.idOrder = Convert.ToInt32(row[0].ToString());
                ord.createDate = Convert.ToDateTime(row[1].ToString());
                ord.idProduct = Convert.ToInt32(row[2].ToString());
                ord.idAddress = Convert.ToInt32(row[3].ToString());
                lista.Add(ord);
            }
            return lista;
        }
  
    }
}