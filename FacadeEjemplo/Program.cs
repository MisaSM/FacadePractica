using FacadeEjemplo.Contact;
using FacadeEjemplo.Facade;

namespace FacadeEjemplo
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContactSystem contactSystem = new ContactSystem();

            MainFacade facade = new MainFacade(contactSystem);

            Console.WriteLine(facade.create().ToString());

        }
    }
}