using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Mark_SO
{
    public class GetAllMarksFromStudentFromSelectedSubjectSO : SystemOperationBase
    {
        public List<Mark> Result { get; private set; }
        Mark m = new Mark();
        Class c = new Class();
        Teacher t = new Teacher();
        Subject s = new Subject();
        private int idSubject;
        private int idStudent;

        public GetAllMarksFromStudentFromSelectedSubjectSO(int idSubject, int idStudent)
        {
            this.idSubject = idSubject;
            this.idStudent = idStudent;
        }

        string select = "m.value,m.examinationtype,m.dateofexamination";

        //$"select from mark m join Class c on (m.IdClass=c.IdClass) join teacher t on (c.IdTeacher=t.IdTeacher) join subject s on (t.IdSubject=s.IdSubject) where m.IdStudent={idStudent} and s.idsubject={idSubject} and m.finalvalue is null

        protected override void Execute()
        {
            Result= repository.GetAllColIsNull4IDOSelect(m, c, t, s,select, "IdClass", "IdTeacher", "IdSubject", "IdStudent", idStudent, "idsubject", idSubject, "finalvalue").OfType<Mark>().ToList();
            //Result = repository.GetAllColIsNull4IDO(m, c, t, s, "IdClass", "IdTeacher", "IdSubject", "IdStudent", idStudent, "idsubject", idSubject, "finalvalue").OfType<Mark>().ToList();
        }
    }
}
