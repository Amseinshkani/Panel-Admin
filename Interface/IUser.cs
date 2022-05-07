using System.Collections.Generic;
using PanelAdmin.Model;

namespace PanelAdmin.Interface
{
    public interface IUser
    {
         bool AddProudact();
         bool UpdateProudact(int Id);
         bool DeleteProudact(int Id);
         List<MUser> ShowAllProudact();
    }
}