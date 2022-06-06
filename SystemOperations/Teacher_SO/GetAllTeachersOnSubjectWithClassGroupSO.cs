using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Teacher_SO
{
    public class GetAllTeachersOnSubjectWithClassGroupSO : SystemOperationBase
    {
        private readonly int idSubject;
        Teacher t = new Teacher();
        Subject s = new Subject();
        ClassGroupDatabase cg = new ClassGroupDatabase();
        public List<Teacher> Result { get; private set; }
        public GetAllTeachersOnSubjectWithClassGroupSO(int idSubject)
        {
            this.idSubject = idSubject;
        }

        protected override void Execute()
        {
            //$"select * from Teacher t join Subject s on t.IdSubject=s.IdSubject join ClassGroup cg on cg.IdClassGroup=t.IdClassHomeroomTeacher where s.IdSubject={subjectId} order by t.lastname asc";
            Result = repository.GetAlltable3WhereOrderByAsc(t, s,cg, "idsubject", "IdClassGroup", "IdClassHomeroomTeacher","idsubject",idSubject,"lastname").OfType<Teacher>().ToList();
        }
    }
}
