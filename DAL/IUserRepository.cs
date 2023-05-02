using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WPFLogin.Models;

namespace WPFLogin.DAL
{
    interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential); //This class admits in the construct a secureString password and we can get password as plain text

        void Add(user userModel);
        user GetById(int userId);
        user GetByUserName(string userName);
        IEnumerable<user> GetByAll();


    }
    /* Here we have a boolean method for user authentication as parameters we define user and password but since in the view and in the viewModel password
     * is of secureString type*/
}
