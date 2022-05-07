using System;
using System.Collections.Generic;
using PanelAdmin.Interface;
using PanelAdmin.Model;

namespace PanelAdmin.Services
{
    public class SUser : IUser
    {
        List<MUser> ListDB = new List<MUser>();

        public bool AddProudact()
        {
            MUser MU = new MUser();
            System.Console.WriteLine("Enter Id : ");
            MU.Id = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter Category : ");
            MU.Category = Console.ReadLine();

            System.Console.WriteLine("Enter Proudact : ");
            MU.Proudact = Console.ReadLine();
            System.Console.WriteLine("Enter Price : ");
            MU.Price = int.Parse(Console.ReadLine());

            if (MU.Status !=false)
            {
                Console.WriteLine(MU.Status == true);
            }
            ListDB.Add(MU);
            return true;
        }

        public bool UpdateProudact(int Id)
        {
            MUser A = new MUser();
            if (Id == A.Id)
            {
                System.Console.WriteLine("Enter Category : ");
                A.Category = Console.ReadLine();

                System.Console.WriteLine("Enter Proudact : ");
                A.Proudact = Console.ReadLine();

                System.Console.WriteLine("Enter Price : ");
                A.Price = int.Parse(Console.ReadLine());

                return true;
            }
            return false;
        }

        public bool DeleteProudact(int Id)
        {
            throw new System.NotImplementedException();
        }

        public List<MUser> ShowAllProudact()
        {
            foreach (var item in ListDB)
            {
                if (ListDB != null)
                {
                    System.Console.WriteLine(item.Id);
                    System.Console.WriteLine(item.Category);
                    System.Console.WriteLine(item.Proudact);
                    System.Console.WriteLine(item.Price);
                    System.Console.WriteLine(item.Status);
                }
            }
            return ListDB;
        }
    }
}
