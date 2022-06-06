using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Mixed_SOs
{
    public class RemoveSubjectAndTeachersOnSubjectSO : SystemOperationBase
    {
        private readonly int idSubject;
        private readonly BindingList<Teacher> teachersList;
        Subject s = new Subject();
        public int Result { get; set; } = 1;

        public RemoveSubjectAndTeachersOnSubjectSO(int idSubject,BindingList<Teacher> teachersList)
        {
            this.idSubject = idSubject;
            this.teachersList = teachersList;
        }
        protected override void Execute()
        {
            try
            {                
                //brisanje profesora
                foreach(Teacher t in teachersList)
                {
                    repository.DeleteByCriteria(t, "idteacher", t.IdTeacher);
                }
                //brisanje premeta
                repository.DeleteByCriteria(s, "idsubject", idSubject);
                Result = 2;
            }
            catch (Exception)
            {
                Result = 0;
                throw;
            }
        }
    }
}
