using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triplegSystem.Model;

namespace triplegSystem.Controller
{
    internal class MainController
    {
        public bool ChekIsRegistered(string username, string password)
        {
            using (GrantDBEntities db = new GrantDBEntities())
            {
                return db.Users.ToList().Where(u => u.UserName == username &&
                                                                   u.Password == password).Any();
            }

        }
    }   
}
