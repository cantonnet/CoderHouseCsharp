using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    internal class Producto
    {
        //Constructor sin parametros
        public Producto() 
        {
            this._id = 0;
            this._descripcion = string.Empty;
            this._costo = 0;
            this._precioventa = 0;
            this._stock = 0;
            this._idusuario = 0;
        }
        //Constructor con parametros
        public Producto(int id, string descripcion, float costo, float precioventa, int stock, int idusuario)
        {
            this._id = id;
            this._descripcion = descripcion;
            this._costo = costo;
            this._precioventa = precioventa;
            this._stock = stock;
            this._idusuario = idusuario;
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public float Costo { get; set; }
        public float Precioventa { get; set; }
        public int Stock { get; set; }
        public int Idusuario { get; set; }

        //Atributos
        private int _id;
        private string _descripcion;
        private float _costo;
        private float _precioventa;
        private int _stock;
        private int _idusuario;
    }
}
