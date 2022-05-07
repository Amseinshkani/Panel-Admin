using System;
using System.Collections.Generic;
using PanelAdmin.Interface;
using PanelAdmin.Model;

namespace PanelAdmin.Services
{
    public class SPanelAdmin : IPanelAdmin
    {
        List<MUser> A = new List<MUser>();

        public bool requestAccept()
        {
            SUser A = new SUser();
            MUser S = new MUser();
            if (S.Status != false)
            {
                A.ShowAllProudact();
                return true;
            }
            else
            {
                Console.WriteLine("Users did not enter a value");
                return false;
            }
        }
    }
}
