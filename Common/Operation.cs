using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum Operation
    {
        #region Class_SO
        AddClass,
        #endregion

        #region ClassGroup_SO
        AddClassGroup,
        ClassGroupAlreadyHadClassOfThatSubjectOnThatDay,        
        GetAllClassGroupsFromSelectedYear,
        GetAllClassGroups,
        GetFirstFreeClassgrouoDependingOnYear,
        GetStreamFromClassGroup,
        #endregion

        #region Mark_SO
        AddAllMarks,
        AddFinalMark,
        AddMark,
        GetAllConcludedMarksFromStudent,
        GetAllMarksFromStudentFromSelectedSubject,
        GetAllMarksFromStudent,
        GetConcludedMarkFromStudentOnSubject,
        MarksIsConcluded,
        #endregion

        #region Student_SO
        AddAllStudents,
        AddStudent,
        ChangeStudentInfo,
        FindStudent,
        GetAllStudentsFromClassGroup,
        GetAllStudents,
        RemoveStudent,
        FindStudentByJMBG,
        FindStudentByName,
        #endregion

        #region Subject_SO        
        AddSubject,                     
        ChangeSubjectDescription,        
        GetAllSubjects,
        GetLatestSubjectDescription,
        RemoveSubject,
        GetAll1stMath,
        GetAll2ndMath,
        GetAll3rdMath,
        GetAll4thMath,
        GetAll1st2ndSocial,
        GetAll3rdSocial,
        GetAll4thSocial,
        #endregion

        #region Teacher_SO
        AddAllTeachers,
        AddTeacherOnNewSubject,
        AddTeacher,       
        GetAllFreeTeachers,       
        GetAllTeachersOnSubject,
        GetAllTeachersOnSubjectWithClassGroup,
        GetAllTeachersOnSubjectWithoutClassGroup,
        GetAllTeachersWithClassGroup,
        GetAllTeachersWithoutClassGroup,
        GetHomeroomTeacher,
        PutHomeroomTeacher,
        RemoveTeacher,
        #endregion

        #region User_SO
        ChangePassword,       
        GetAllUsers,
        GetChangedPassword,
        Login,
        #endregion

        #region Mixed
        AddClassGroup_HomeroomTeacher_Students,
        AddNewSubjectAndTeachers,
        SaveClassAndAssignedMarks,
        SaveClassAndFinalMark,
        RemoveSubjectAndTeachersOnSubjectSO,
        #endregion

        End

    }
}
