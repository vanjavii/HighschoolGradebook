using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Subject_SO
{
    public class RemoveSubjectSO : SystemOperationBase
    {
        private readonly int idSubject;
        Subject s = new Subject();
        public int Result { get; private set; }

        public RemoveSubjectSO(int idSubject)
        {
            this.idSubject = idSubject;
        }

        protected override void Execute()
        {            
            try
            {
                repository.DeleteByCriteria(s, "idsubject", idSubject);
                Result = 1;
            }
            catch (Exception)
            {
                Result = 2;
            }
        }
    }
}
