using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEjemplo.Model
{
    public class ContactModel
    {
        //Generamos nuestra clase...
        public string Name { get; set; }

        public string Email { get; set; }

        public string? Phone { get; set; }
        public string Password { get; set; }


        public ContactModel(string name, string email, string phone, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Password = password;
        }


        //Esto pa desplegarla bien bonito en la consola
        public override string ToString()
        {
            return $"Nombre de usuario: {Name} \nCorreo electronico: {Email} \nNumero telefonico: {Phone} \nContrasenya: {Password}";

        }

    }
}
