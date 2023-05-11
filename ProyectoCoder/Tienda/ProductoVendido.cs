using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    internal class ProductoVendido
    {
        //Constructor sin parametros
        public ProductoVendido() 
        {
            this._id = 0;
            this._idproducto = 0;
            this._stock = 0;
            this._idVenta = 0;
        }
        //Constructor con parametros
        public ProductoVendido(int id, int idproducto, int stock, int idVenta)
        {
            this._id = id;
            this._idproducto = idproducto;
            this._stock = stock;
            this._idVenta = idVenta;
        }
        // get an set

        public int Id { get; set; }
        public int Idproducto { get; set; }
        public int Stock { get; set; }
        public int Venta { get; set; }

        //Atributos

        private int _id;
        private int _idproducto;
        private int _stock;
        private int _idVenta;

    }
}
