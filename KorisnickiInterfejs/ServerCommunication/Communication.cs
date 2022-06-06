//using Common;
using Common;
using Domain;
using KorisnickiInterfejs.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiInterfejs.ServerCommunication
{
    public class Communication
    {
        private Socket socket;
        private CommunicationHelper helper;
        public User CurrentUser { get; set; }

        public object GetResult1()
        {
            Response response = helper.Receive<Response>();
            if (response.IsSuccessful)
            {
                return response.Result;
            }
            else throw new SystemOperationException(response.Message);
        }

        #region Singlton
        private static Communication instance;
        private Communication()
        {
        }
        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }
        #endregion

        #region private void GetResult()        
        private void GetResult()
        {
            Response response = helper.Receive<Response>();
            if (!response.IsSuccessful)
            {
                throw new SystemOperationException(response.Message);
            }
        }
        #endregion

        #region public Output SendRequestGetResult<Output>(Common.Operation op, object i = null) where Output : class
        public Output SendRequestGetResult<Output>(Common.Operation op, object i = null) where Output : class
        {
            SendRequest(op, i);
            return GetResult<Output>();
        }
        #endregion

        #region private void SendRequest(Operation operation, object requestObject = null)
        private void SendRequest(Operation operation, object requestObject = null)
        {
            try
            {
                Request r = new Request
                {
                    Operation = operation,
                    RequestObject = requestObject
                };
                helper.Send(r);
            }
            catch (IOException ex)
            {
                throw new ServerCommunicationException(ex.Message);
            }
        }
        #endregion

        #region private void SendRequestMINE(Operation operation, object requestObject = null)
        private void SendRequestMINE(Operation operation, object requestObject = null, object par2=null, object par3=null, object par4=null)
        {
            try
            {
                Request r = new Request
                {
                    Operation = operation,
                    RequestObject = requestObject,
                    Par2=par2,
                    Par3=par3,
                    Par4=par4
                };
                helper.Send(r);
            }
            catch (IOException ex)
            {
                throw new ServerCommunicationException(ex.Message);
            }
        }
        #endregion

        #region public void SendRequestNoResult(Operation op, object i)
        public void SendRequestNoResult(Operation op, object i)
        {
            SendRequest(op, i);
            GetResult();
        }
        #endregion

        #region private T GetResult<T>() where T : class
        private T GetResult<T>() where T : class
        {
            Response response = helper.Receive<Response>();
            if (response.IsSuccessful)
            {
                return (T)response.Result;
            }
            else
            {
                throw new SystemOperationException(response.Message);
            }
        }
        #endregion

        public bool ClassGroupAlreadyHadClassOfThatSubjectOnThatDay(int cgId, int idSubject)
        {
            SendRequestMINE(Operation.ClassGroupAlreadyHadClassOfThatSubjectOnThatDay, cgId, idSubject);
            return (bool)GetResult1();
        }

        public object GetAllClassGroupsFromSelectedYear(int selectedYear)
        {
            SendRequest(Operation.GetAllClassGroupsFromSelectedYear, selectedYear);
            return (List<ClassGroupDatabase>)GetResult1();
        }

        public object GetAllClassGroups()
        {
            SendRequest(Operation.GetAllClassGroups);
            return (List<ClassGroupDatabase>)GetResult1();
        }

        public int GetFirstFreeClassGroupIdDependingOnYear(int year)
        {
            SendRequest(Operation.GetFirstFreeClassgrouoDependingOnYear, year);
            return (int)GetResult1();
        }

        public bool GetStreamFromClassGroup(int idClassGroup)
        {
            SendRequest(Operation.GetStreamFromClassGroup, idClassGroup);
            return (bool)GetResult1();
        }

        public BindingList<Mark> GetAllConcludedMarksFromStudent(int idStud)
        {
            SendRequest(Operation.GetAllConcludedMarksFromStudent, idStud);
            return (BindingList<Mark>)GetResult1();
        }
        
        public BindingList<Mark> GetAllMarksFromStudentFromSelectedSubject(int idSubject, int idStudent)
        {
            SendRequestMINE(Operation.GetAllMarksFromStudentFromSelectedSubject, idSubject, idStudent);
            return (BindingList<Mark>)GetResult1();
        }

        public int GetConcludedMarkFromStudentOnSubject(int idSubject, int idStudent)
        {
            SendRequestMINE(Operation.GetAllMarksFromStudentFromSelectedSubject, idSubject, idStudent);
            return (int)GetResult1();
        }

        public Student FindStudentByJMBG(string jmbg)
        {
            SendRequest(Operation.FindStudentByJMBG, jmbg);
            return (Student)GetResult1();
        }

        public bool MarkIsConcluded(int idSubj, int idStudent)
        {
            SendRequestMINE(Operation.MarksIsConcluded, idSubj, idStudent);
            return (bool)GetResult1();
        }

        public int AddStudent(Student s)
        {
            SendRequest(Operation.AddStudent, s);
            return (int)GetResult1();
        }

        public int ChangeStudentInfo(int idStudent, string address, string phoneNumber, int classGroupId)
        {
            SendRequestMINE(Operation.ChangeStudentInfo, idStudent, address, phoneNumber, classGroupId);
            return (int)GetResult1();
        }

        public Student FindStudentById(int idStudent)
        {
            SendRequest(Operation.FindStudent, idStudent);
            return (Student)GetResult1();
        }

        public List<Student> GetStudentsFromSelectedClassGroup(int cgId)
        {
            SendRequest(Operation.GetAllStudentsFromClassGroup, cgId);
            return (List<Student>)GetResult1();
        }

        public List<Student> GetAllStudents()
        {
            SendRequest(Operation.GetAllStudents);
            return (List<Student>)GetResult1();            
        }

        public int RemoveStudentWithId(int selectedId)
        {
            SendRequest(Operation.RemoveStudent, selectedId);
            return (int)GetResult1();
        }

        public int ChangeSubjectDescription(string newDescription, int subjectId)
        {
            SendRequestMINE(Operation.ChangeSubjectDescription, newDescription, subjectId);
            return (int)GetResult1();
        }

        public object GetAllSubjects()
        {
            SendRequest(Operation.GetAllSubjects);
            return (List<Subject>)GetResult1();
        }

        public string GetLatestSubjectDescription(int idSubject)
        {
            SendRequest(Operation.GetLatestSubjectDescription, idSubject);
            return (string)GetResult1();
        }

        public int RemoveSubjectWithId(int idSubject)
        {
            SendRequest(Operation.RemoveSubject, idSubject);
            return (int)GetResult1();
        }

        #region PREDMETI PO GODINAMA

        public BindingList<Subject> GetAllSubjects_2nd_Math()
        {
            SendRequest(Operation.GetAll2ndMath);
            return (BindingList<Subject>)GetResult1();
        }

        public BindingList<Subject> GetAllSubjects_3rd_Math()
        {
            SendRequest(Operation.GetAll3rdMath);
            return (BindingList<Subject>)GetResult1();
        }

        public Student FindStudentByName(string studentName)
        {
            SendRequest(Operation.FindStudentByName, studentName);
            return (Student)GetResult1();
        }

        public BindingList<Subject> GetAllSubjects_4th_Math()
        {
            SendRequest(Operation.GetAll4thMath);
            return (BindingList<Subject>)GetResult1();
        }
        public BindingList<Subject> GetAllSubjects_1st_2nd_Social()
        {
            SendRequest(Operation.GetAll1st2ndSocial);
            return (BindingList<Subject>)GetResult1();
        }

        public BindingList<Subject> GetAllSubjects_3rd_Social()
        {
            SendRequest(Operation.GetAll3rdSocial);
            return (BindingList<Subject>)GetResult1();
        }

        public BindingList<Subject> GetAllSubjects_4th_Social()
        {
            SendRequest(Operation.GetAll4thSocial);
            return (BindingList<Subject>)GetResult1();
        }

        #endregion

        public int AddTeacher(Teacher t)
        {
            SendRequest(Operation.AddTeacher, t);
            return (int)GetResult1();
        }

        public List<Teacher> GetAllFreeTeachers()
        {
            SendRequest(Operation.GetAllFreeTeachers);
            return (List<Teacher>)(GetResult1());
        }

        public List<Teacher> GetAllTeachersOnSubject(int idSubj)
        {
            SendRequest(Operation.GetAllTeachersOnSubject, idSubj);
            return (List<Teacher>)GetResult1();
        }

        public List<Teacher> GetAllTeachersWithoutClassGroup()
        {
            Request request = new Request() { Operation = Operation.GetAllTeachersWithoutClassGroup };
            //client.SendRequest(request);
            SendRequest(Operation.GetAllTeachersWithoutClassGroup);
            return (List<Teacher>)GetResult1();
        }

        public Teacher GetHomeroomTeacher(int selectedCG)
        {
            SendRequest(Operation.GetHomeroomTeacher, selectedCG);
            return (Teacher)GetResult1();
        }          

        public void RemoveTeacherWithId(int idTeacher)
        {
            SendRequest(Operation.RemoveTeacher, idTeacher);
            GetResult1();
        }       

        public int ChangeUserPassword(User current, string password)
        {
            SendRequestMINE(Operation.ChangePassword, current, password);
            return (int)GetResult1();
        }

        public string GetChangedPassword(int idUser)
        {
            SendRequest(Operation.GetChangedPassword, idUser);
            return (string)GetResult1();
        }

        #region LOGIN 
        public User Login(User user)
        {
            SendRequest(Operation.Login, user);
            CurrentUser = (User)GetResult1();
            return CurrentUser;            
        }
        #endregion

        #region mixed SOs
        public void AddClassGroup_HomeRoomTeacher_Students(ClassGroupDatabase cg, Teacher t, List<Student> list)
        {
            SendRequestMINE(Operation.AddClassGroup_HomeroomTeacher_Students, cg, t, list);
            GetResult();
        }

        public int AddNewSubjectAndTeachers(List<Teacher> list, Subject s)
        {
            SendRequestMINE(Operation.AddNewSubjectAndTeachers, list, s);
            return (int)GetResult1();
        }

        public int SaveClassAndAssignedMarks(Class schoolClass, BindingList<Mark> assignedMarks)
        {
            SendRequestMINE(Operation.SaveClassAndAssignedMarks, schoolClass, assignedMarks);
            return (int)GetResult1();
        }

        public int SaveClassAndFinalMark(Class concludeClass, Mark finalMark)
        {
            SendRequestMINE(Operation.SaveClassAndFinalMark,concludeClass, finalMark);
            return (int)GetResult1();
        }

        public int RemoveSubjectAndTeachersOnSubject(int subjectIdent, BindingList<Teacher> teacherList)
        {
            SendRequestMINE(Operation.RemoveSubjectAndTeachersOnSubjectSO, subjectIdent, teacherList);
            return (int)GetResult1();
        }

        #endregion

        #region  public void Connect()
        public void Connect()
        {
            if (socket == null || !socket.Connected)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                helper = new CommunicationHelper(socket);
            }
        }
        #endregion

        #region public void Close()
        public void Close()
        {
            if (socket == null) return;
            Request request = new Request
            {
                Operation = Operation.End,
            };
            helper.Send(request);

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            socket = null;
        }
        #endregion
    }
}
