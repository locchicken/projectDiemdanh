using Biden.Model;
using ĐIEMANHHS;
using ĐIEMANHHS.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biden.Data
{
    public class DataHelper
    {
        public static Account CheckLogin(string user, string pass, string query)
        {
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    Account acc = new Account();
                    acc.setUser(user);
                    acc.setPass(pass);
                    return acc;
                }
            }
            return null;
        }

        //load teacher_Info
        public static List<TeacherInfo> FindTeacher(string query)
        {
           
                using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
                {
                    connec.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connec);
                    MySqlDataReader data = cmd.ExecuteReader();
                    List<TeacherInfo> list = new List<TeacherInfo>();
                    while (data.Read() == true)
                    {
                 
                        TeacherInfo teacher = new TeacherInfo();
                        teacher.setID(data.GetString("Tchr_ID"));
                        if (!data.IsDBNull(1))
                        {
                             teacher.setName(data.GetString("Tchr_Name"));
                         }
                        if(!data.IsDBNull(2))
                        {
                            teacher.setSex(data.GetString("Tchr_Sex"));
                        }
                        if (!data.IsDBNull(4))
                        {
                            teacher.setAddress(data.GetString("Tchr_Address"));
                        }
                        if (!data.IsDBNull(5))
                        {
                            teacher.setPhone(data.GetString("Tchr_Phone"));
                        }
                        teacher.setBOD(data.GetString("Tchr_BOD"));
                        teacher.setMail(data.GetString("Tchr_Mail"));
                        teacher.setRole(data.GetString("Tchr_Role"));
                        teacher.setSchool(data.GetInt32("Tchr_inSchool"));
                        list.Add(teacher);
                      }
                    return list;
                }
           
           
        }

        //insert teacher_info
        public static Boolean InsertTearcher(TeacherInfo teacher)
        {
            string id = teacher.getID();
            string name = teacher.getName();
            string sex = teacher.getSex();
            string bod = teacher.getBOD();
            string address = teacher.getAddress();
            string phone = teacher.getPhone();
            string mail = teacher.getMail();
            string role = teacher.getRole();
            string query = "insert myclassroombiden.teacher_info(Tchr_ID,Tchr_Name,Tchr_Sex,Tchr_BOD,Tchr_Address,Tchr_Phone,Tchr_Mail,Tchr_Role) values('" + id + "',N'" + name + "',N'" + sex + "','" + bod + "','" + address + "','" + phone + "','" + mail + "','" + role + "')";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //load tài khoản
        public static List<Account> FindAccount(string query)
        {
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                MySqlDataReader data = cmd.ExecuteReader();
                List<Account> list = new List<Account>();
                while (data.Read() == true)
                {
                    Account teacher = new Account();
                    teacher.setID(data.GetString("STT"));
                    teacher.setUser(data.GetString("Tchr_ID"));
                    teacher.setPass(data.GetString("Tchr_Pass"));
                    teacher.setAdmin(data.GetInt32("isAdmin"));
                    teacher.setType(data.GetInt32("Tchr_Type"));
                    list.Add(teacher);
                }
                return list;
            }
        }

        //thêm tài khoản
        public static Boolean InsertAccount(Account account)
        {
            string user = account.getUser();
            string mail = account.getEmail();
            string pass = account.getPass();
            int type = account.getType();
            int admin = account.getAdmin();
            string role = account.getRole();
            string query = "call myclassroombiden.sp_insertTeacher('"+ user + "',N'"+mail+"', N'"+pass+"', "+type+", "+admin+", N'"+role+"');";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                cmd.ExecuteNonQuery();
                return true;
            }
            
        }
        //xóa tài khoản
        public static Boolean DeleteAccount(Account account)
        {
            string id = account.getID();
            string query = "delete from myclassroombiden.teacher_login where STT='" + id + "'";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        //update tài khoản
        //public static Boolean UpdateAccount(Account account)
        //{
        //    string id = account.getID();
        //    string user = account.getUser();
        //    string pass = account.getPass();
        //    int isadmin = account.getIsAdmin();
        //    string query = "update myclassroombiden.teacher_login set Tchr_ID='" + user + "',Tchr_Pass='" + pass + "',isAdmin='" + isadmin + "' where STT='" + id + "'";
        //    using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
        //    {
        //        connec.Open();
        //        MySqlCommand cmd = new MySqlCommand(query, connec);
        //        return cmd.ExecuteNonQuery() > 0;
        //    }
        //}

        //load tài khoản theo id
        public static Account FindAccountID(string id)
        {
            string query = "select* from teacher_login where Tchr_ID='" + id + "'";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    Account account = new Account();
                    account.setID(data.GetString("STT"));
                    account.setUser(data.GetString("Tchr_ID"));
                    account.setAdmin(data.GetInt32("isAdmin"));
                    return account;
                }
                return null;
            }
        }
        //check tồn tại trong teacher
        public static TeacherInfo FindTeacherID(string id)
        {
            string query = "select* from teacher_info where Tchr_ID='" + id + "'";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    TeacherInfo teacher = new TeacherInfo();
                    teacher.setID(data.GetString("Tchr_ID"));
                    teacher.setRole(data.GetString("Tchr_Role"));
                    teacher.setSchool(data.GetInt32("Tchr_inSchool"));
                    return teacher;
                }
                return null;
            }
        }
        //update teacher
        public static Boolean UpdateTeacher(TeacherInfo teacher)
        {
            string id = teacher.getID();
            string name = teacher.getName();
            string sex = teacher.getSex();
            string bod = teacher.getBOD();
            string address = teacher.getAddress();
            string phone = teacher.getPhone();
            string mail = teacher.getMail();
            string role = teacher.getRole();
            string query = "update myclassroombiden.teacher_info set Tchr_Name='" + name + "',Tchr_Sex='" + sex + "',Tchr_BOD='" + bod + "',Tchr_Address='" + address + "',Tchr_Phone='" + phone + "',Tchr_Mail='" + mail + "',Tchr_Address='" + address + "' where Tchr_ID='" + id + "'";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        //xóa teacher
        public static Boolean DeleteTeacher(TeacherInfo teacher)
        {
            string id = teacher.getID();
            string query = "delete from myclassroombiden.teacher_info where Tchr_ID='" + id + "'";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //load khoa
        public static List<Faculty> FindFaculty(string query)
        {
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                MySqlDataReader data = cmd.ExecuteReader();
                List<Faculty> list = new List<Faculty>();
                while (data.Read() == true)
                {
                    Faculty Fc = new Faculty();
                    Fc.setID(data.GetString("FCT_ID"));
                    Fc.setName(data.GetString("FCT_Name"));
                    list.Add(Fc);
                }
                return list;
            }
        }
        //thêm khoa
        public static Boolean InsertFaculty(string user,string id,string name)
        {
            string query = "call myclassroombiden.sp_insertFaculty('"+ user + "', '"+id+"', N'"+name+"');";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                cmd.ExecuteNonQuery();
                return true;
            }
        }
        //update khoa
        public static Boolean UpdateFaculty(Faculty Fc)
        {
            string id = Fc.getID();
            string name = Fc.getName();
            string query = "update myclassroombiden.faculty set FCT_ID='" + id + "',FCT_Name='" + name + "' where FCT_ID='" + id + "'";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        //xóa khoa
        public static Boolean DeleteFaculty(Faculty Fc)
        {
            string id = Fc.getID();
            string query = "delete from myclassroombiden.faculty where FCT_ID='" + id + "'";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //load chuyên ngành
        public static List<Speciality> FindSpeciality(string query)
        {
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                MySqlDataReader data = cmd.ExecuteReader();
                List<Speciality> list = new List<Speciality>();
                while (data.Read() == true)
                {
                    Speciality Fc = new Speciality();
                    Fc.setID(data.GetString("SPC_ID"));
                    Fc.setName(data.GetString("SPC_Name"));
                    Fc.setFaculty(data.GetString("SPC_Faculty"));
                    list.Add(Fc);
                }
                return list;
            }
        }
        //thêm chuyên ngành
        public static Boolean InsertSpeciality(string user,string id,string name,string idFa)
        {
            string query = "call myclassroombiden.sp_insertSpeciality('" + user + "', '" + id + "', N'" + name + "','"+idFa+"');";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                cmd.ExecuteNonQuery();
                return true;
            }
        }
        //update chuyên ngành
        public static Boolean UpdateSpeciality(Speciality sp)
        {
            string id = sp.getID();
            string name = sp.getName();
            string faculty = sp.getFaculty();
            string query = "update myclassroombiden.speciality set SPC_Name='" + name + "',SPC_Faculty='" + faculty + "' where SPC_ID='" + id + "'";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        //xóa chuyên ngành
        public static Boolean DeleteSpeciality(Speciality sp)
        {
            string id = sp.getID();
            string query = "delete from myclassroombiden.speciality where SPC_ID='" + id + "'";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //load lớp đại học
        public static List<Class_uni> FindClassUni(string query)
        {
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                MySqlDataReader data = cmd.ExecuteReader();
                List<Class_uni> list = new List<Class_uni>();
                while (data.Read() == true)
                {
                    Class_uni Fc = new Class_uni();
                    Fc.setID(data.GetString("CLU_ID"));
                    Fc.setSpec(data.GetString("CLU_Speciality"));
                    Fc.setFaculty(data.GetString("CLU_Faculty"));
                    list.Add(Fc);
                }
                return list;
            }
        }
        //thêm lớp đại học
        public static Boolean InsertClassUni(string user, string idclass, string idspec, string idFa)
        {
            string query = "call myclassroombiden.sp_insertClass_UNI('" + user + "', '" + idclass + "', N'" + idspec + "','" + idFa + "');";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                cmd.ExecuteNonQuery();
                return true;
            }
        }
        //update lớp đại học
        public static Boolean UpdateClassUni(Class_uni u)
        {
            string id = u.getID();
            string spec = u.getSpec();
            string faculty = u.getFaculty();
            string query = "update myclassroombiden.class_uni set CLU_Speciality='" + spec + "',CLU_Faculty='" + faculty + "' where CLU_ID='" + id + "'";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        //xóa lớp đại học
        public static Boolean DeleteClassUni(Class_uni u)
        {
            string id = u.getID();
            string query = "delete from myclassroombiden.class_uni where CLU_ID='" + id + "'";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public static List<WriteLog> FindWriteLog(string query)
        {
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                MySqlDataReader data = cmd.ExecuteReader();
                List<WriteLog> list = new List<WriteLog>();
                while (data.Read() == true)
                {
                    WriteLog wr = new WriteLog();
                    wr.setActive(data.GetString("Activities"));
                    wr.setTime(data.GetString("onCreated"));
                    list.Add(wr);
                }
                return list;
            }
        }
        //update
        public static Boolean updateGiaovien(string user,string id,string role,int in_skl)
        {
            string query = "call myclassroombiden.sp_updateRole_Work('" + user + "',N'" + id + "', N'" + role + "', " + in_skl + ");";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                cmd.ExecuteNonQuery();
                return true;
            }

        }
        //checkpass
        public static Account CheckPass(string user,string pass)
        {
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                string query = "call myclassroombiden.sp_teacherLogin('" + user + "', '" + pass + "');";
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    Account acc = new Account();
                    acc.setPass(pass);
                    return acc;
                }
            }
            return null;
        }
        //changePass
        public static Boolean changePass(string user, string pass,string passnew)
        {
            string query = "call myclassroombiden.sp_changePassword('" + user + "', '" + pass + "','"+passnew+"');";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                cmd.ExecuteNonQuery();
                return true;
            }
        }
        //THPT
        public static List<ClassTHPT> FindTHPT(string query)
        {
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                MySqlDataReader data = cmd.ExecuteReader();
                List<ClassTHPT> list = new List<ClassTHPT>();
                while (data.Read() == true)
                {
                    ClassTHPT Fc = new ClassTHPT();
                    Fc.setID(data.GetString("CLHS_ID"));
                    list.Add(Fc);
                }
                return list;
            }
        }
        //thêm chuyên ngành
        public static Boolean InsertTHPT(string user,string id)
        {
            string query = "call myclassroombiden.sp_insertClass_HS('" + user + "', '" + id + "');";
            using (MySqlConnection connec = new MySqlConnection(KetNoi.connection))
            {
                connec.Open();
                MySqlCommand cmd = new MySqlCommand(query, connec);
                cmd.ExecuteNonQuery();
                return true;
            }
        }
    }
}
