using System;
using System.Collections.Generic;
using System.Data;

namespace Segundo_Parcial_POO
{
    public static class AddressDAO
    {

        public static List<Adress> getAdresses()
        {
            string query = $"SELECT * FROM ADDRESS"; 

            DataTable dt = DBConnection.ExecuteQuery(query);

            List<Adress> list = new List<Adress>();
            foreach (DataRow row in dt.Rows)
            {
                Adress adr = new Adress();
                adr.idAdress = Convert.ToInt32(row[0].ToString());
                adr.idUser = Convert.ToInt32(row[1].ToString());
                adr.adress = row[2].ToString();
                list.Add(adr);
            }
            return list;
        }

        public static void InsertAdress(AppUser user, string adr)
        {
            string query = $"INSERT INTO ADDRESS(idUser, address) VALUES({user.idUser}, '{adr}');";
            DBConnection.ExecuteNonQuery(query);
        }

        public static void DeleteAddress(Adress ad)
        {
            string query = $"DELETE FROM ADDRESS WHERE idAddress = {ad.idAdress};";
            DBConnection.ExecuteNonQuery(query);
        }

        public static DataTable AddressesFromUser(AppUser user)
        {
            string query = $"SELECT ad.idAddress, ad.address FROM ADDRESS ad WHERE idUser = {user.idUser};";
            
            DataTable dataT = DBConnection.ExecuteQuery(query);
            return dataT;
            
        }

        public static void UpdateAdress(Adress ad, string newAddress)
        {
            string query = $"UPDATE ADDRESS SET address = '{newAddress}'WHERE idAddress = {ad.idAdress};";
            DBConnection.ExecuteNonQuery(query);
        }
        
        
    }
}
    
    
