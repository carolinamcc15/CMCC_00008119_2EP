using System;
using System.Collections.Generic;
using System.Data;

namespace Segundo_Parcial_POO
{
    public static class ProductsDAO
    {
        public static List<Product> getProducts(Business bs)
        {
            string query = $"SELECT * FROM PRODUCT  WHERE idBusiness = {bs.idBusiness}";

            DataTable dt = DBConnection.ExecuteQuery(query);

            List<Product> lista = new List<Product>();
            foreach (DataRow row in dt.Rows)
            {
                Product p = new Product();
                p.idProduct = Convert.ToInt32(row[0].ToString());
                p.idBusiness = Convert.ToInt32(row[1].ToString());
                p.name = row[2].ToString();
                lista.Add(p);
            }
            return lista;
        }

        public static void InsertProduct(Business bs, string name)
        {
            string query = $"INSERT INTO PRODUCT(idBusiness, name) VALUES({bs.idBusiness},'{name}');";
            DBConnection.ExecuteNonQuery(query);
        }

        public static void DeleteProduct(Product pro)
        {
            string query = $"DELETE FROM PRODUCT WHERE idProduct = {pro.idProduct};";
            DBConnection.ExecuteNonQuery(query);
        }
    }
}