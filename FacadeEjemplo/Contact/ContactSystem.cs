using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FacadeEjemplo.Model;

namespace FacadeEjemplo.Contact
{
    public class ContactSystem
    {
        public ContactModel CreateContact() 
        {
            Console.WriteLine("Introduzca el nombre de usuario");
            string name = Console.ReadLine();

            Console.WriteLine("Introduzca el email");
            string email = Console.ReadLine();

            Console.WriteLine("Introduzca el numero telefonico");
            string phone = Console.ReadLine();

            Console.WriteLine("Introduzca la contrasenya");
            string password = Console.ReadLine();

            ContactModel contacto1 = new ContactModel(name, email, phone, password);
            
            return contacto1;
        }

        

    }
}
