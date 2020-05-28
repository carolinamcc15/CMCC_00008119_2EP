using System;
using System.Collections.Generic;
using System.Data;

namespace Segundo_Parcial_POO
{
    public static class AppUserDAO
    {

        public static void CreateAppUser(AppUser user)
        {
            string query = $"INSERT INTO APPUSER(fullname, username, password, userType) "
                           + $"VALUES('{user.fullName}', '{user.username}', '{user.password}', {user.userType});";
            DBConnection.ExecuteNonQuery(query);
        }
        
        public static List<AppUser> getAppUsers()
        {
            string query = $"SELECT * FROM APPUSER";

            DataTable dt = DBConnection.ExecuteQuery(query);

            List<AppUser> lista = new List<AppUser>();
            foreach (DataRow row in dt.Rows)
            {
                AppUser user = new AppUser();
                user.idUser = Convert.ToInt32(row[0].ToString());
                user.fullName = row[1].ToString();
                user.username = row[2].ToString();
                user.password = row[3].ToString();
                user.userType = Convert.ToBoolean(row[4].ToString());
                lista.Add(user);
            }
            return lista;
        }

        public static void ExistentUsername(string username)
        {
            List<AppUser> users = getAppUsers();
            byte contador = 0;
            foreach (var user in users)
            {
                if(user.username.Equals(username))
                    contador++;
            }

            if (contador > 0)
            {
                throw new ExistentUsernameException("El nombre de usuario ya existe");
            }
        }
        public static AppUser VerifyAppUser(String username, String password)
        {
            AppUser user = new AppUser();
            String query = $"SELECT * FROM APPUSER WHERE username = '{username}' AND password = '{password}';";
            DataTable table= DBConnection.ExecuteQuery(query);
            user.idUser = Convert.ToInt32(table.Rows[0][0].ToString());
            user.fullName = table.Rows[0][1].ToString();
            user.username = table.Rows[0][2].ToString();
            user.password = table.Rows[0][3].ToString();
            user.userType = Convert.ToBoolean(table.Rows[0][4].ToString());
            return user;
        }
        
        public static void UpdatePassword(AppUser user, string newPass)
        {
            string query = $"UPDATE APPUSER SET password = '{newPass}' WHERE iduser = {user.idUser};";
            DBConnection.ExecuteNonQuery(query);
        }
        
        public static void DeleteUser(AppUser appUser)
        {
            string query = $"DELETE FROM APPUSER WHERE idUser = {appUser.idUser};";
            DBConnection.ExecuteNonQuery(query);
        }

        public static DataTable ViewAppUsers()
        {
            string query = $"SELECT * FROM APPUSER ORDER BY iduser;";

            DataTable dataT = DBConnection.ExecuteQuery(query);
            return dataT;
        }
    }
}