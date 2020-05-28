namespace Segundo_Parcial_POO
{
    public class AppUser
    {
        public int idUser { get; set; }
        public string fullName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool userType { get; set; }

        public AppUser(){}
        
        public AppUser(int idUsuario, string fullName, string username, string password, bool userType)
        {
            this.idUser = idUsuario;
            this.fullName = fullName;
            this.username = username;
            this.password = password;
            this.userType = userType;
        }
    }
}