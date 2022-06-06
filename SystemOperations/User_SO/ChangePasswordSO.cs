using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.User_SO
{
    public class ChangePasswordSO : SystemOperationBase
    {
        private readonly User u;
        private readonly string newPassword;
        public int Result { get; private set; }

        public ChangePasswordSO(User u, string newPassword)
        {
            this.u = u;
            this.newPassword = newPassword;
        }

        protected override void Execute()
        {
            try
            {
                repository.Change(u, "password", newPassword, "iduser", u.IdUser);
                Result = 1;
            }
            catch
            {
                Result = 0;
            }
        }
    }
}
