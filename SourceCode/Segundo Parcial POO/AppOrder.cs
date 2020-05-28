using System;

namespace Segundo_Parcial_POO
{
    public class AppOrder
    {
        public int idOrder {get; set; }
        public DateTime createDate {get; set; }
        public int idProduct {get; set; }
        public int idAddress {get; set; }

        public AppOrder() { }

        public AppOrder(int idOrder, DateTime date, int idProduct, int idAddress)
        {
            this.idOrder = idOrder;
            createDate = date;
            this.idProduct = idProduct;
            this.idAddress = idAddress;
        }
    }
}