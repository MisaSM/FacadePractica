using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeEjemplo.Contact;
using FacadeEjemplo.Model;

namespace FacadeEjemplo.Facade
{
    public class MainFacade
    {
        protected ContactSystem _contact;


        public  MainFacade(ContactSystem contact)
        {
                this._contact = contact;
        }

        public ContactModel create() 
        {
            Console.WriteLine("Iniciando programa...");
            return this._contact.CreateContact();
        }

    }
}
