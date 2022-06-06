using ApplicationLogic;
using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket socket;
        private CommunicationHelper helper;

        public EventHandler OdjavljenKlijent;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            helper = new CommunicationHelper(socket);
        }

        private bool kraj = false;
        public void HandleRequests()
        {
            try
            {
                while (!kraj)
                {
                    Request request = helper.Receive<Request>();
                    Response response = CreateResponse(request);
                    helper.Send(response);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
                CloseSocket();
            }
        }
     
        public Response CreateResponse(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    //case Operation.AddClass:
                    //    Class c = (Class)request.RequestObject;
                    //    Controller.Instance.AddClass(c);
                    //    break;
                    //case Operation.AddClassGroup:
                    //    ClassGroupDatabase cg1 = (ClassGroupDatabase)request.RequestObject;
                    //    Controller.Instance.AddNewClassGroup(cg1);
                    //    break;
                    case Operation.ClassGroupAlreadyHadClassOfThatSubjectOnThatDay:
                        int classG = (int)request.RequestObject;
                        int idSubj = (int)request.Par2;
                        response.Result = Controller.Instance.ClassGroupAlreadyHadClassOfThatSubjectOnThatDay(classG, idSubj);
                        break;
                    case Operation.GetAllClassGroupsFromSelectedYear:
                        int selectedYear = (int)request.RequestObject;
                        response.Result = Controller.Instance.GetAllClassGroupsFromSelectedYear(selectedYear);
                        break;
                    case Operation.GetAllClassGroups:
                        response.Result = Controller.Instance.GetAllClassGroups();
                        break;
                    case Operation.GetFirstFreeClassgrouoDependingOnYear:
                        int year = (int)request.RequestObject;
                        response.Result = Controller.Instance.GetFirstFreeClassGroupIdDependingOnYear(year);
                        break;
                    case Operation.GetStreamFromClassGroup:
                        int idCg = (int)request.RequestObject;
                        response.Result = Controller.Instance.GetStreamFromClassGroup(idCg);
                        break;
                    //case Operation.AddAllMarks:
                    //    break;
                    //case Operation.AddFinalMark:
                    //    break;
                    //case Operation.AddMark:
                    //    Mark m = (Mark)request.RequestObject;
                    //    Controller.Instance.AddMark(m);
                    //    break;
                    case Operation.GetAllConcludedMarksFromStudent:
                        int studdId = (int)request.RequestObject;
                        response.Result = Controller.Instance.GetAllConcludedMarksFromStudent(studdId);
                        break;
                    case Operation.GetAllMarksFromStudentFromSelectedSubject:
                        int idSubj2 = (int)request.RequestObject;
                        int idStud2 = (int)request.Par2;
                        response.Result = Controller.Instance.GetAllMarksFromStudentFromSelectedSubject(idSubj2, idStud2);
                        break;
                    //case Operation.GetAllMarksFromStudent:                        
                    //    int idS = (int)request.RequestObject;
                    //    response.Result = Controller.Instance.GetAllMarksFromStudent(idS);
                    //    break;
                    case Operation.GetConcludedMarkFromStudentOnSubject:
                        int idSubject1 = (int)request.RequestObject;
                        int idStudent1 = (int)request.Par2;
                        response.Result = Controller.Instance.GetConcludedMarkFromStudentOnSubject(idSubject1, idStudent1);
                        break;
                    case Operation.MarksIsConcluded:
                        int idSubj1 = (int)request.RequestObject;
                        int idStud1 = (int)request.Par2;
                        response.Result = Controller.Instance.MarkIsConcluded(idSubj1, idStud1);
                        break;
                    //case Operation.AddAllStudents:
                    //    break;
                    case Operation.AddStudent:
                        Student s = (Student)request.RequestObject;
                        response.Result = Controller.Instance.AddStudent(s);
                        break;
                    case Operation.ChangeStudentInfo:
                        int studentID = (int)request.RequestObject;
                        string address = (string)request.Par2;
                        string phoneNum = (string)request.Par3;
                        int classGroupID = (int)request.Par4;
                        response.Result = Controller.Instance.ChangeStudentInfo(studentID, address, phoneNum, classGroupID);
                        break;
                    case Operation.FindStudent:
                        //Student ss = (Student)request.RequestObject;
                        int studIdd = (int)request.RequestObject;
                        response.Result = Controller.Instance.FindStudentById(studIdd);
                        break;
                    case Operation.GetAllStudentsFromClassGroup:
                        int selecCg = (int)request.RequestObject;
                        response.Result = Controller.Instance.GetStudentsFromSelectedClassGroup(selecCg);
                        break;
                    case Operation.GetAllStudents:
                        response.Result = Controller.Instance.GetAllStudents();
                        break;
                    case Operation.RemoveStudent:
                        int studId = (int)request.RequestObject;
                        response.Result = Controller.Instance.RemoveStudentWithId(studId);
                        break;
                    //case Operation.AddSubject:
                    //    Subject sub = (Subject)request.RequestObject;
                    //    Controller.Instance.AddNewSubject(sub);
                    //    break;
                    case Operation.ChangeSubjectDescription:
                        string newDesc = (string)request.RequestObject;
                        int idSub = (int)request.Par2;
                        response.Result = Controller.Instance.ChangeSubjectDescription(newDesc, idSub);
                        break;
                    case Operation.GetAllSubjects:
                        response.Result = Controller.Instance.GetAllSubjects();
                        break;
                    case Operation.GetLatestSubjectDescription:
                        int idSubje = (int)request.RequestObject;
                        response.Result = Controller.Instance.GetLatestSubjectDescription(idSubje);
                        break;
                    case Operation.RemoveSubject:
                        int idSubjj = (int)request.RequestObject;
                        response.Result = Controller.Instance.RemoveSubjectWithId(idSubjj);
                        break;
                    case Operation.GetAll1stMath:
                        response.Result = Controller.Instance.GetAllSubjects_1th_Math();
                        break;
                    case Operation.GetAll2ndMath:
                        response.Result = Controller.Instance.GetAllSubjects_2nd_Math();
                        break;
                    case Operation.GetAll3rdMath:
                        response.Result = Controller.Instance.GetAllSubjects_3rd_Math();
                        break;
                    case Operation.GetAll4thMath:
                        response.Result = Controller.Instance.GetAllSubjects_4th_Math();
                        break;
                    case Operation.GetAll1st2ndSocial:
                        response.Result = Controller.Instance.GetAllSubjects_1st_2nd_Social();
                        break;
                    case Operation.GetAll3rdSocial:
                        response.Result = Controller.Instance.GetAllSubjects_3rd_Social();
                        break;
                    case Operation.GetAll4thSocial:
                        response.Result = Controller.Instance.GetAllSubjects_4th_Social();
                        break;
                    //case Operation.AddAllTeachers:
                    //    break;
                    //case Operation.AddTeacherOnNewSubject:
                    //    //PROBLEM
                    //    break;
                    case Operation.AddTeacher:
                        Teacher t = (Teacher)request.RequestObject;
                        try
                        {
                            response.Result = Controller.Instance.AddTeacher(t);
                            //response.Result = 1;
                        }
                        catch (Exception)
                        {
                            response.Result = 0;
                            //throw;
                        }
                        break;
                    case Operation.GetAllFreeTeachers:
                        response.Result = Controller.Instance.GetAllFreeTeachers();
                        break;
                    case Operation.GetAllTeachersOnSubject:
                        int IDSub = (int)request.RequestObject;
                        response.Result = Controller.Instance.GetAllTeachersOnSubject(IDSub);
                        break;
                    //case Operation.GetAllTeachersOnSubjectWithClassGroup:
                    //    break;
                    //case Operation.GetAllTeachersOnSubjectWithoutClassGroup:
                    //    break;
                    //case Operation.GetAllTeachersWithClassGroup:
                    //    break;
                    case Operation.GetAllTeachersWithoutClassGroup:
                        response.Result = Controller.Instance.GetAllTeachersWithoutClassGroup();
                        break;
                    case Operation.GetHomeroomTeacher:
                        int selectedCg = (int)request.RequestObject;
                        response.Result = Controller.Instance.GetHomeroomTeacher(selectedCg);
                        break;
                    //case Operation.PutHomeroomTeacher:
                    //    break;
                    case Operation.RemoveTeacher:
                        //Teacher t1 = (Teacher)request.RequestObject;
                        int idToRemove = (int)request.RequestObject;
                        Controller.Instance.RemoveTeacherWithId(idToRemove);
                        break;
                    case Operation.ChangePassword:
                        User user = (User)request.RequestObject;
                        string pass = (string)request.Par2;
                        response.Result = Controller.Instance.ChangeUserPassword(user, pass);
                        break;
                    //case Operation.GetAllUsers:
                    //    response.Result = Controller.Instance.GetAllUsers();
                    //    break;
                    case Operation.GetChangedPassword:
                        int idUser = (int)request.RequestObject;
                        response.Result = Controller.Instance.GetChangedPassword(idUser);
                        break;
                    case Operation.Login:
                        response.Result = Controller.Instance.Login((User)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.IsSuccessful = false;
                            response.Message = "User with those credentials doesn't exist!";
                        }
                        break;
                    case Operation.End:
                        kraj = true;
                        break;
                    case Operation.AddClassGroup_HomeroomTeacher_Students:
                        ClassGroupDatabase cg = (ClassGroupDatabase)request.RequestObject;
                        Teacher teacher = (Teacher)request.Par2;
                        List<Student> studentsList = (List<Student>)request.Par3;
                        Controller.Instance.AddClassGroup_HomeRoomTeacher_Students(cg, teacher, studentsList);
                        break;
                    case Operation.AddNewSubjectAndTeachers:
                        List<Teacher> teachersList = (List<Teacher>)request.RequestObject;
                        Subject newSubject = (Subject)request.Par2;
                        response.Result = Controller.Instance.AddNewSubjectAndTeachers(teachersList, newSubject);
                        break;
                    case Operation.SaveClassAndAssignedMarks:
                        Class cl = (Class)request.RequestObject;
                        BindingList<Mark> marksList = (BindingList<Mark>)request.Par2;
                        response.Result = Controller.Instance.SaveClassAndAssignedMarks(cl, marksList);
                        break;
                    case Operation.SaveClassAndFinalMark:
                        Class concludeClass = (Class)request.RequestObject;
                        Mark finalMark = (Mark)request.Par2;
                        response.Result = Controller.Instance.SaveClassAndFinalMark(concludeClass, finalMark);
                        break;
                    case Operation.RemoveSubjectAndTeachersOnSubjectSO:
                        int subjectIdent = (int)request.RequestObject;
                        BindingList<Teacher> teacherList = (BindingList<Teacher>)request.Par2;
                        response.Result = Controller.Instance.RemoveSubjectAndTeachersOnSubject(subjectIdent, teacherList);
                        break;                   
                    case Operation.FindStudentByJMBG:
                        string jmbgStudent = (string)request.RequestObject;
                        response.Result = Controller.Instance.FindStudentByJMBG(jmbgStudent);
                        break;
                    case Operation.FindStudentByName:
                        string nameOfStudent = (string)request.RequestObject;
                        response.Result = Controller.Instance.FindStudentByName(nameOfStudent);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                response.IsSuccessful = false;
                response.Message = ex.Message;
            }
            return response;
        }

        private object lockobject = new object();

        internal void CloseSocket()
        {
            lock (lockobject)
            {
                if (socket != null)
                {
                    kraj = true;
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    socket = null;
                    OdjavljenKlijent?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
