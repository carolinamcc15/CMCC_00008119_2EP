﻿namespace Segundo_Parcial_POO
{
    public class Product
    {
        public int idProduct {get; set; }
        public int idBusiness {get; set; }
        public string name {get; set; }

        public Product(){}
        
        public Product(int idProduct, int idBusiness, string name)
        {
            this.idProduct = idProduct;
            this.idBusiness = idBusiness;
            this.name = name;
        }
    }
}