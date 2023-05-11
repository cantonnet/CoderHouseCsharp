using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    internal class Venta
    {   
        //Constructor sin parametros
        public Venta()
        {
            this._id = 0;
            this._comentarios = string.Empty;
            this._idusuario = 0;
        }
        //Constructor con parametros
        public Venta(int id, string comentarios, int idusuario)
        {
            this._id = id;
            this._comentarios = comentarios;
            this._idusuario = idusuario;
        }

        // get an set
        public int Id { get; set; }
        public string Comentarios { get; set; }
        public int IDusuario { get; set; }


        //atributos
        private int _id;
        private string _comentarios;
        private int _idusuario;

        
    }
}
