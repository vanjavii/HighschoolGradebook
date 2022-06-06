using DatabaseBroker;
using Domain;
using Repository.DatabaseRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;
using SystemOperations.Class_SO;
using SystemOperations.ClassGroup_SO;
using SystemOperations.Mark_SO;
using SystemOperations.Mixed_SOs;
//using SystemOperations;
using SystemOperations.Student_SO;
using SystemOperations.Subject_SO;
using SystemOperations.Subject_SO.Mathematical;
using SystemOperations.Subject_SO.Social;
using SystemOperations.Teacher_SO;
using SystemOperations.User_SO;

namespace ApplicationLogic
{
    public class Controller
    {
        //IRepository<Student> studentRepository = new StudentDatabaseRepository();
        private Broker broker = new Broker();
        #region Singlton pattern
        private static Controller instance;
        private Controller()
        {
        }

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }
        #endregion
        public User CurrentUser { get; private set; }

        #region public int AddMark(Mark m)               
        public int AddMark(Mark m)
        {
            SystemOperationBase so = new AddMarkSO(m);
            so.ExecuteTemplate();
            if (((AddMarkSO)so).Result == 1)
            {
                return 1;
            }
            else return 0;
        }
        #endregion

        #region public int AddClass(Class c)              
        public int AddClass(Class c)
        {
            SystemOperationBase so = new AddClassSO(c);
            so.ExecuteTemplate();
            return ((AddMarkSO)so).Result;
        }
        #endregion

        #region public User Login(User user) 
        public User Login(User user)
        {
            SystemOperationBase so = new LoginSO(user);
            so.ExecuteTemplate();
            if ((((LoginSO)so).Result)!=null)
            {
                CurrentUser = user;
            }
            else { throw new Exception(); };
            return ((LoginSO)so).Result;
        }
#endregion

        #region  GetStudentsFromSelectedClassGroup(int selectedCG) 
        public List<Student> GetStudentsFromSelectedClassGroup(int selectedClassGroup)
        {
            SystemOperationBase so = new GetAllStudentsFromClassGroupSO(selectedClassGroup);
            so.ExecuteTemplate();
            return ((GetAllStudentsFromClassGroupSO)so).Result;
        }
        #endregion

        #region GetAllUsers 
        public List<User> GetAllUsers()
        {
            SystemOperationBase so = new GetAllUsersSO();
            so.ExecuteTemplate();
            return ((GetAllUsersSO)so).Result;
        }
        #endregion

        #region AddStudent   
        public int AddStudent(Student student)
        {
            SystemOperationBase so = new AddStudentSO(student);
            so.ExecuteTemplate();
            if (((AddStudentSO)so).Result == 1)
            {
                return 1;
            }
            else return 0;           
        }
        #endregion

        #region ChangeUserPassword(User u,string password) preko FrmMyProfile 
        public int ChangeUserPassword(User u, string password)
        {
            SystemOperationBase so = new ChangePasswordSO(u, password);
            so.ExecuteTemplate();
            if (((ChangePasswordSO)so).Result == 1)
            {
                return 1;
            }
            else return 0;            
        }
        #endregion

        #region GetAllStudents() 
        public List<Student> GetAllStudents()
        {
            SystemOperationBase so = new GetAllStudentsSO();
            so.ExecuteTemplate();
            return ((GetAllStudentsSO)so).Result;            
        }
        #endregion

        #region GetAllSubject()
        public List<Subject> GetAllSubjects()
        {
            SystemOperationBase so = new GetAllSubjectsSO();
            so.ExecuteTemplate();
            return ((GetAllSubjectsSO)so).Result;            
        }
        #endregion

        #region AddTeacher(Teacher t)  
        public int AddTeacher(Teacher t)
        {
            SystemOperationBase so = new AddTeacherSO(t);
            so.ExecuteTemplate();
            return ((AddTeacherSO)so).Result;            
        }
        #endregion

        #region GetAllClassGroupsFromSelectedYear(int year)
        public List<ClassGroupDatabase> GetAllClassGroupsFromSelectedYear(int year)
        {
            SystemOperationBase so = new GetAllClassGroupsFromSelectedYearSO(year);
            so.ExecuteTemplate();
            return ((GetAllClassGroupsFromSelectedYearSO)so).Result;           
        }
        #endregion

        #region GetAllClassGroups
        public List<ClassGroupDatabase> GetAllClassGroups()
        {
            SystemOperationBase so = new GetAllClassGroupsSO();
            so.ExecuteTemplate();
            return ((GetAllClassGroupsSO)so).Result;            
        }
        #endregion

        #region GetAllTeachersWithoutClassGroup()
        public List<Teacher> GetAllTeachersWithoutClassGroup()
        {
            SystemOperationBase so = new GetAllTeachersWithoutClassGroupSO();
            so.ExecuteTemplate();
            return ((GetAllTeachersWithoutClassGroupSO)so).Result;
        }
        #endregion

        #region GetAllTeachersOnSubject(int selectedSubjectId) 
        public List<Teacher> GetAllTeachersOnSubject(int selectedSubjectId)
        {
            SystemOperationBase so = new GetAllTeachersOnSubjectSO(selectedSubjectId);
            so.ExecuteTemplate();
            return (((GetAllTeachersOnSubjectSO)so).Result);            
        }
        #endregion

        #region GetAllTeachersOnSubjectWithClassGroup(int selectedSubjectId)  
        public BindingList<Teacher> GetAllTeachersOnSubjectWithClassGroup(int selectedSubjectId)
        {
            SystemOperationBase so = new GetAllTeachersOnSubjectWithClassGroupSO(selectedSubjectId);
            return new BindingList<Teacher>(((GetAllTeachersOnSubjectWithClassGroupSO)so).Result);            
        }
        #endregion

        #region GetAllTeachersOnSubjectWithoutClassGroup(int selectedSubjectId)  
        public BindingList<Teacher> GetAllTeachersOnSubjectWithoutClassGroup(int selectedSubjectId)
        {
            SystemOperationBase so = new GetAllTeachersOnSubjectWithoutClassGroupSO(selectedSubjectId);
            return new BindingList<Teacher>(((GetAllTeachersOnSubjectWithoutClassGroupSO)so).Result);            
        }
        #endregion

        #region ChangeSubjectDescription(string description,int subjectId)  
        public int ChangeSubjectDescription(string description, int subjectId)
        {
            SystemOperationBase so = new ChangeSubjectDescriptionSO(description, subjectId);
            so.ExecuteTemplate();
            if ((((ChangeSubjectDescriptionSO)so).Result) == 1)
            {
                return 1;
            }
            else return 0;            
        }
        #endregion

        #region FindStudentById(int idStudent)  
        public Student FindStudentById(int idStudent)
        {
            SystemOperationBase so = new FindStudentSO(idStudent);
            so.ExecuteTemplate();
            return ((FindStudentSO)so).Result;            
        }
        #endregion

        #region ChangeStudentInfo(int idStudent,string address, string phoneNumber, int classgroupId)
        public int ChangeStudentInfo(int idStudent, string address, string phoneNumber, int classgroupId)
        {
            SystemOperationBase so = new ChangeStudentInfoSO(idStudent, address, phoneNumber, classgroupId);
            so.ExecuteTemplate();
            return ((ChangeStudentInfoSO)so).Result;            
        }
        #endregion

        #region public int AddNewSubjectAndTeachers(List<Teacher> teachers, Subject subject) 
        public int AddNewSubjectAndTeachers(List<Teacher> teachers,Subject subject)
        {
            SystemOperationBase so = new AddNewSubjectAndTeachersSO(teachers, subject);
            so.ExecuteTemplate();
            return ((AddNewSubjectAndTeachersSO)so).Result;            
        }
        #endregion

        #region int AddNewSubject(Subject subject)  
        public int AddNewSubject(Subject subject)
        {
            SystemOperationBase so = new AddSubjectSO(subject);
            so.ExecuteTemplate();
            if (((AddSubjectSO)so).Result != 0)
            {
                return ((AddSubjectSO)so).Result;
            }
            else return 0;            
        }
        #endregion

        #region Student FindStudentByName(string nameOfStudent)
        public Student FindStudentByName(string nameOfStudent)
        {
            SystemOperationBase so = new FindStudentByNameSO(nameOfStudent);
            so.ExecuteTemplate();
            return ((FindStudentByNameSO)so).Result;
        }
        #endregion

        #region Student FindStudentByJMBG(string jmbgStudent)
        public Student FindStudentByJMBG(string jmbgStudent)
        {
            SystemOperationBase so = new FindStudentByJmbgSO(jmbgStudent);
            so.ExecuteTemplate();
            return ((FindStudentByJmbgSO)so).Result;
        }
        #endregion

        #region AddAllTeachers(List<Teacher> teachers, int sId) 
        public void AddAllTeachers(List<Teacher> teachers, int subjectId)
        {
            SystemOperationBase so = new AddAllTeachersSO(teachers, subjectId);
            so.ExecuteTemplate();           
        }
        #endregion

        #region RemoveStudentWithId  
        public int RemoveStudentWithId(int selectedId)
        {
            SystemOperationBase so = new RemoveStudentSO(selectedId);
            so.ExecuteTemplate();
            if ((((RemoveStudentSO)so).Result) == 1)
            {
                return 1;
            }
            else return 0;           
        }
        #endregion

        #region Teacher GetHomeroomTeacher(int selectedCG)
        public Teacher GetHomeroomTeacher(int selectedCG)
        {
            SystemOperationBase so = new GetHomeroomTeacherSO(selectedCG);
            so.ExecuteTemplate();
            return ((GetHomeroomTeacherSO)so).Result;            
        }
        #endregion

        #region BindingList<Teacher> GetAllFreeTeachers()
        public List<Teacher> GetAllFreeTeachers()
        {
            SystemOperationBase so = new GetAllFreeTeachersSO();
            so.ExecuteTemplate();
            return ((GetAllFreeTeachersSO)so).Result;            
        }
        #endregion

        #region AddNewClassGroup(ClassGroupDatabase classGroup)
        public int AddNewClassGroup(ClassGroupDatabase classGroup)
        {
            SystemOperationBase so = new AddClassGroupSO(classGroup);
            so.ExecuteTemplate();
            return ((AddClassGroupSO)so).Result;           
        }
        #endregion

        #region AddAllStudents(List<Student> students, int classId) 
        public void AddAllStudents(List<Student> students, int classId)
        {
            SystemOperationBase so = new AddAllStudentsSO(students, classId);
            so.ExecuteTemplate();            
        }
        #endregion

        #region void PutHomeroomTeacher(Teacher t, int cgId)
        public void PutHomeroomTeacher(Teacher t, int cgId)
        {
            SystemOperationBase so = new PutHomeroomTeacherSO(t, cgId);
            so.ExecuteTemplate();          
        }
        #endregion

        #region GetLatestSubjectDescription(int selectedSubject) 
        public string GetLatestSubjectDescription(int selectedSubject)
        {
            SystemOperationBase so = new GetLatestSubjectDescriptionSO(selectedSubject);
            so.ExecuteTemplate();
            return ((GetLatestSubjectDescriptionSO)so).Result;            
        }
        #endregion

        #region public int SaveClassAndAssignedMarks(Domain.Class schoolClass, BindingList<Mark> marks)
        public int SaveClassAndAssignedMarks(Class schoolClass, BindingList<Mark> marks)
        {
            SystemOperationBase so= new SaveClassAndAssignedMarksSO(schoolClass, marks);
            try
            {
                so.ExecuteTemplate();
                int check = ((SaveClassAndAssignedMarksSO)so).Success;                
                return check;              
            }
            catch (Exception)
            {
                throw;
            }          
        }
        #endregion

        #region public int GetFirstFreeClassGroupIdDependingOnYear(int yearOfStudies)
        public int GetFirstFreeClassGroupIdDependingOnYear(int yearOfStudies)
        {
            SystemOperationBase so = new GetFirstFreeClassGroupDependingOnYearSO(yearOfStudies);
            so.ExecuteTemplate();
            return ((GetFirstFreeClassGroupDependingOnYearSO)so).Result;            
        }
        #endregion

        #region AddClassGroup_HomeRoomTeacher_Students(ClassGroupDatabase cg, Teacher homeRoomTeacher,List<Student> students)
        public void AddClassGroup_HomeRoomTeacher_Students(ClassGroupDatabase cg, Teacher homeRoomTeacher,List<Student> students)
        {
            SystemOperationBase so = new AddClassGroup_HomeRoomTeacher_StudentsSO(cg, homeRoomTeacher, students);
            so.ExecuteTemplate();            
        }
        #endregion

        #region int RemoveTeacherWithId(int idTeacher)
        public int RemoveTeacherWithId(int idTeacher)
        {
            SystemOperationBase so = new RemoveTeacherSO(idTeacher);
            so.ExecuteTemplate();
            return ((RemoveTeacherSO)so).Result;               
        }
        #endregion

        #region int RemoveSubjectWithId(int idSubject)
        public int RemoveSubjectWithId(int idSubject)
        {
            SystemOperationBase so = new RemoveSubjectSO(idSubject);
            so.ExecuteTemplate();
            if ((((RemoveTeacherSO)so).Result) == 1)
            {
                return 1;
            }
            else return 2;          
        }
        #endregion

        #region GetChangedPassword(int idUser)
        public string GetChangedPassword(int idUser)
        {
            SystemOperationBase so = new GetChangedPasswordSO(idUser);
            so.ExecuteTemplate();
            return ((GetChangedPasswordSO)so).Result;           
        }
        #endregion

        #region GetStreamFromClassGroup(int idClassGroup)
        public bool GetStreamFromClassGroup(int idClassGroup)
        {
            SystemOperationBase so = new GetStreamFromClassGroupSO(idClassGroup);
            so.ExecuteTemplate();
            return ((GetStreamFromClassGroupSO)so).Result;            
        }
        #endregion

        #region GetAllSubjects_1st_2nd_Social()
        public BindingList<Subject> GetAllSubjects_1st_2nd_Social()
        {
            SystemOperationBase so=new GetAll1st2ndSocialSO();
            so.ExecuteTemplate();
            return new BindingList<Subject>(((GetAll1st2ndSocialSO)so).Result);           
        }
        #endregion

        #region GetAllSubjects_3rd_Social
        public BindingList<Subject> GetAllSubjects_3rd_Social()
        {
            SystemOperationBase so = new GetAll3rdSocialSO();
            so.ExecuteTemplate();
            return new BindingList<Subject>(((GetAll3rdSocialSO)so).Result);            
        }
        #endregion

        #region GetAllSubjects_4th_Social
        public BindingList<Subject> GetAllSubjects_4th_Social()
        {
            SystemOperationBase so = new GetAll4thSocialSO();
            so.ExecuteTemplate();
            return new BindingList<Subject>(((GetAll4thSocialSO)so).Result);           
        }
        #endregion

        #region GetAllSubjects_1th_Math()
        public object GetAllSubjects_1th_Math()
        {
            SystemOperationBase so = new GetAll1stMathSO();
            so.ExecuteTemplate();
            return new BindingList<Subject>(((GetAll1stMathSO)so).Result);           
        }
#endregion

        #region GetAllSubjects_3nd_Math()
        public BindingList<Subject> GetAllSubjects_3rd_Math()
        {
            SystemOperationBase so = new GetAll3rdMathSO();
            so.ExecuteTemplate();
            return new BindingList<Subject>(((GetAll3rdMathSO)so).Result);            
        }
        #endregion

        #region GetAllSubjects_4th_Math()
        public BindingList<Subject> GetAllSubjects_4th_Math()
        {
            SystemOperationBase so = new GetAll4thMathSO();
            so.ExecuteTemplate();
            return new BindingList<Subject>(((GetAll4thMathSO)so).Result);            
        }
        #endregion

        #region GetAllSubjects_2nd_Math()
        public object GetAllSubjects_2nd_Math()
        {
            SystemOperationBase so = new GetAll2ndMathSO();
            so.ExecuteTemplate();
            return new BindingList<Subject>(((GetAll2ndMathSO)so).Result);            
        }
        #endregion

        #region ClassGroupAlreadyHadClassOfThatSubjectOnThatDay(int idClassGroup, int idSubject)
        public bool ClassGroupAlreadyHadClassOfThatSubjectOnThatDay(int idClassGroup, int idSubject)
        {
            SystemOperationBase so = new ClassGroupAlreadyHadClassOfThatSubjectOnThatDaySO(idClassGroup, idSubject);
            so.ExecuteTemplate();
            return ((ClassGroupAlreadyHadClassOfThatSubjectOnThatDaySO)so).Result;           
        }
        #endregion

        #region BindingList<Mark> GetAllMarksFromStudent(int idStudent)
        public BindingList<Mark> GetAllMarksFromStudent(int idStudent)
        {
            SystemOperationBase so = new GetAllMarksFromStudentSO(idStudent);
            so.ExecuteTemplate();
            return new BindingList<Mark>(((GetAllMarksFromStudentSO)so).Result);            
        }
        #endregion

        #region BindingList<Mark> GetAllMarksFromStudentFromSelectedSubject(int idSubject, int idStudent)
        public BindingList<Mark> GetAllMarksFromStudentFromSelectedSubject(int idSubject, int idStudent)
        {
            SystemOperationBase so = new GetAllMarksFromStudentFromSelectedSubjectSO(idSubject, idStudent);
            so.ExecuteTemplate();
            return new BindingList<Mark>(((GetAllMarksFromStudentFromSelectedSubjectSO)so).Result);            
        }
        #endregion

        #region ZAKLJUCIVANJE OCENA, mala modifikacija dodele ocena
        public int SaveClassAndFinalMark(Class schoolClass, Mark mark)
        {
            SystemOperationBase so = new SaveClassAndFinalMarkSO(schoolClass, mark);
            so.ExecuteTemplate();
            return ((SaveClassAndFinalMarkSO)so).Success;           
        }
        #endregion

        #region public bool MarkIsConcluded(int idSubject, int idStudent)
        public bool MarkIsConcluded(int idSubject, int idStudent)
        {
            SystemOperationBase so = new MarkIsConcludedSO(idSubject, idStudent);
            so.ExecuteTemplate();
            return ((MarkIsConcludedSO)so).Result;            
        }
        #endregion

        #region public BindingList<Mark> GetAllConcludedMarksFromStudent(int idStudent)
        public BindingList<Mark> GetAllConcludedMarksFromStudent(int idStudent)
        {
            SystemOperationBase so = new GetAllConcludedMarksFromStudentSO(idStudent);
            so.ExecuteTemplate();
            return new BindingList<Mark>(((GetAllConcludedMarksFromStudentSO)so).Result);           
        }
        #endregion

        #region RemoveSubjectAndTeachersOnSubject(int subjectIdent, BindingList<Teacher> teacherList)
        public int RemoveSubjectAndTeachersOnSubject(int subjectIdent, BindingList<Teacher> teacherList)
        {
            SystemOperationBase so = new RemoveSubjectAndTeachersOnSubjectSO(subjectIdent, teacherList);
            so.ExecuteTemplate();
            return ((RemoveSubjectAndTeachersOnSubjectSO)so).Result;
        }
        #endregion

        #region GetConcludedMarkFromStudentOnSubject(int idSubject1, int idStudent1)
        public int GetConcludedMarkFromStudentOnSubject(int idSubject1, int idStudent1)
        {
            SystemOperationBase so = new GetConcludedMarkFromStudentOnSubjectSO(idSubject1,idStudent1 );
            so.ExecuteTemplate();
            return ((GetConcludedMarkFromStudentOnSubjectSO)so).MarkValue;
        }
        #endregion
    }
}

