using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSVdatabase
{
    public class Database
    {
        private string connectionString = "Data Source=DESKTOP-O0DKKJE;Initial Catalog=QLSV;Integrated Security=True;Encrypt=False";
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        public Database()
        {
            try
            {
                conn = new SqlConnection(connectionString);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connected Fail " + ex.Message);
            }
        }
        public DataTable SelectData(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var para in lstPara)
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading detailed information: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public int ExeCute(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();
                //cmd = new SqlCommand(sql, conn);
                //return (int)cmd.ExecuteScalar();

                SqlCommand storeProcedure = new SqlCommand(sql, conn);
                storeProcedure.CommandType = CommandType.StoredProcedure;

                foreach (var para in lstPara)
                {
                    storeProcedure.Parameters.AddWithValue(para.key, para.value);
                }




                // Thực thi stored procedure
                int rowsAffected = storeProcedure.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Command execiton error: " + ex.Message);
                return -100;
            }
            finally
            {
                conn.Close();
            }
        }


        public List<TeacherDto> ExeCuteTeacher(string sql)
        {
            List<TeacherDto> teacherList = new List<TeacherDto>();
            try
            {

                conn.Open();

                SqlCommand storeProcedure = new SqlCommand(sql, conn);
                ////storeProcedure.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = storeProcedure.ExecuteReader();
                while (reader.Read())
                {
                    int teacherId = reader.GetInt32(0);
                    string teacherName = reader.GetString(1);

                    teacherList.Add(new TeacherDto()
                    {
                        TeacherId = teacherId,
                        TeacherName = teacherName
                    });
                }
                return teacherList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Command execiton error: " + ex.Message);
                return teacherList;
            }
            finally
            {
                conn.Close();
            }
        }


        public List<SubjectDto> ExeCuteSubject(string sql)
        {
            List<SubjectDto> subjectList = new List<SubjectDto>();
            try
            {

                conn.Open();

                SqlCommand storeProcedure = new SqlCommand(sql, conn);
                ////storeProcedure.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = storeProcedure.ExecuteReader();
                while (reader.Read())
                {
                    int subjectId = reader.GetInt32(0);
                    string subjectName = reader.GetString(1);

                    subjectList.Add(new SubjectDto()
                    {
                        SubjectId = subjectId,
                        SubjectName = subjectName
                    });
                }
                return subjectList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Command execiton error: " + ex.Message);
                return subjectList;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<CourseDto> ExeCuteCourse(string sql, CustomParameter parameter)
        {
            List<CourseDto> listData = new List<CourseDto>();
            try
            {

                conn.Open();

                SqlCommand storeProcedure = new SqlCommand(sql, conn);
                storeProcedure.CommandType = CommandType.StoredProcedure;

                storeProcedure.Parameters.AddWithValue(parameter.key, parameter.value);


                SqlDataReader reader = storeProcedure.ExecuteReader();
                while (reader.Read())
                {
                    string firstName = reader.GetString(0);
                    string nameSubject = reader.GetString(1);
                    int courseID = reader.GetInt32(2);
                    int teacherID = reader.GetInt32(3);
                    int subjectID = reader.GetInt32(4);
                    string nameCourse = reader.GetString(5);
                    listData.Add(new CourseDto()
                    {
                        firstName = firstName,
                        nameSubject = nameSubject,
                        courseID = courseID,
                        teacherID = teacherID,
                        subjectID = subjectID,
                        nameCourse = nameCourse
                    });
                }
                return listData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Command execiton error: " + ex.Message);
                return listData;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<ScoreDto> ExeCuteScore(string sql, List<CustomParameter> listPara)
        {
            List<ScoreDto> listData = new List<ScoreDto>();
            try
            {

                conn.Open();

                SqlCommand storeProcedure = new SqlCommand(sql, conn);
                storeProcedure.CommandType = CommandType.StoredProcedure;

                foreach (CustomParameter param in listPara)
                {
                    storeProcedure.Parameters.AddWithValue(param.key, param.value);
                }



                SqlDataReader reader = storeProcedure.ExecuteReader();
                while (reader.Read())
                {
                    string studentID = reader.GetString(0);
                    int courseID = reader.GetInt32(1);

                    //nếu reader.GetDouble(2) != null
                    //thì double firstTestScore = (float)reader.GetDouble(2)
                    //       ngươc lại
                    //    double firstTestScore = = 0;

                    double firstTestScore = !reader.IsDBNull(2) ? (double)reader.GetDouble(2) : 0;

                    double secondTestScore = !reader.IsDBNull(3) ? (double)reader.GetDouble(3) : 0;
                    string fullName = reader.GetString(4);
                    string nameCourse = reader.GetString(5);

                    listData.Add(new ScoreDto()
                    {
                        studentID = studentID,
                        courseID = courseID,
                        firstTestScore = firstTestScore,
                        secondTestScore = secondTestScore,
                        fullName = fullName,
                        nameCourse = nameCourse
                    });
                }
                return listData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Command execiton error: " + ex.Message);
                return listData;
            }
            finally
            {
                conn.Close();
            }
        }

        public int ExeCuteDelete(string sql, List<CustomParameter> listPara)
        {
            int rowsAffected = 0;
            try
            {

                conn.Open();

                SqlCommand storeProcedure = new SqlCommand(sql, conn);
                storeProcedure.CommandType = CommandType.StoredProcedure;

                foreach (CustomParameter param in listPara)
                {
                    storeProcedure.Parameters.AddWithValue(param.key, param.value);
                }
                rowsAffected = storeProcedure.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Command execiton error: " + ex.Message);
                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

    }

}
