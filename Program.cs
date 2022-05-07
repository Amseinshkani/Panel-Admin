using System;
using PanelAdmin.Services;

namespace PanelAdmin
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            do
            {
                Console.WriteLine("Admin or User");
                string Answer = Console.ReadLine();
                switch (Answer)
                {
                    case "Admin":
                        SPanelAdmin A = new SPanelAdmin();
                        A.requestAccept();

                        break;
                    case "User":
                        SUser B = new SUser();
                        B.AddProudact();

                        break;
                    default:
                        Console.WriteLine("we dont have anything");
                        break;
                }
                System.Console.WriteLine("tamum ya na");
                a= Console.ReadLine();
            }
            while (a != "tamum");
        }
    }
}
