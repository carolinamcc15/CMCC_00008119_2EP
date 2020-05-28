namespace Segundo_Parcial_POO
{
    public class Adress
    {
        public int idAdress { get; set; }
        public string adress { get; set; }
        public int idUser { get; set; }

        public Adress(){}
        
        public Adress(int idAdress, string adress, int idUser)
        {
            this.idAdress = idAdress;
            this.adress = adress;
            this.idUser = idUser;
        }
    }
}