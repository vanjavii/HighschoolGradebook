using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.User_SO
{
    public class LoginSO : SystemOperationBase
    {
        private readonly User u;

        public User Result { get; private set; }

        public LoginSO(User u)
        {
            this.u = u;
        }

        protected override void Execute()
        {            
            try
            {
                Result = (User)repository.GetAll2Where(u, "username", u.Username, "password", u.Password);
            }
            catch (Exception)
            {
                throw new Exception("User with those credentials doesn't exist!");
            }
        }
    }
}
