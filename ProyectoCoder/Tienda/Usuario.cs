using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    internal class Usuario
    {
        //Constructor sin parametros
        public Usuario()
        {
            this._id = 0;
            this._nombre = string.Empty;
            this._password = string.Empty;
            this._nombreUsuario = string.Empty;
            this._email = string.Empty;
        }

        //COnstructor con parametros
        public Usuario(int id, string nombre,string password, string nombreUsuario, string email)
        {
            this._id = id;
            this._nombre = nombre;
            this._password = password;
            this._nombreUsuario = nombreUsuario;
            this._email = email;
        }
        // get an set
        public int Id { get; set; }  
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }

        //Atributos
        private int _id;
        private string _nombre;
        private string _password;
        private string _nombreUsuario;
        private string _email;
    }

}
