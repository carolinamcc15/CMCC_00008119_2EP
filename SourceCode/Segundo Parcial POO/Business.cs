﻿namespace Segundo_Parcial_POO
{
    public class Business
    {
        public int idBusiness { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public Business(){}
        
        public Business(int idBusiness, string name, string description)
        {
            this.idBusiness = idBusiness;
            this.name = name;
            this.description = description;
        }
    }    
}