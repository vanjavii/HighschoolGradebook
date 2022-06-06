using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.User_SO
{
    public class GetChangedPasswordSO : SystemOperationBase
    {
        public string Result { get; private set; }
        User u = new User();
        private int idUser;

        public GetChangedPasswordSO(int idUser)
        {
            this.idUser = idUser;
        }

        protected override void Execute()
        {
            Result = repository.GetColumnValueWhere(u, "password", "iduser", idUser);
        }
    }
}
