using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WPFLogin.Models;

namespace WPFLogin.DAL
{
    class UserRepository : RepositoryBase, IUserRepository
    {
        public void Add(user userModel)
        {
            throw new NotImplementedException();
        }

        public bool AuthenticateUser(NetworkCredential credential)
        {
            bool validUser;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select *from [User] where username=@username and [password]=@password";
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = credential.UserName;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = credential.Password;
                validUser = command.ExecuteScalar() == null ? false : true;
            }
            return validUser;
        }

        public IEnumerable<user> GetByAll()
        {
            throw new NotImplementedException();
        }

        public user GetById(int userId)
        {
            throw new NotImplementedException();
        }

        public user GetByUserName(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
