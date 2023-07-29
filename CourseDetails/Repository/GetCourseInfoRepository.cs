using CourseDetails.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CourseDetails.Repository

{
     public class GetCourseInfoRepository
    {

        public readonly string conectionstring;


        //public Details CourseInfo()
        //{

        //    Details s = new Details();

        //    Console.WriteLine("Enter Course Name");
        //    s.CourseName = Console.ReadLine();

        //    Console.WriteLine("Enter  Duration");
        //    s.Duration = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Enter Name of the University");
        //    s.University = Console.ReadLine();


        //    Console.WriteLine("Enter the course Start Date");
        //    s.StartDate = Console.ReadLine();


        //    Console.WriteLine("Enter  the Number of seats Available");
        //    s.Seats = Convert.ToInt32(Console.ReadLine());
        //    return s;
        //}

        public GetCourseInfoRepository()
        {

            conectionstring = @"Data source=DESKTOP-1U0BM0H\SQLEXPRESS;Initial catalog=SQL_DB;User Id=sa;Password=Anaiyaan@123";
        }
        public List<Details> SelectSP()

        {
            try
            {
                List<Details> constrain = new List<Details>();

                var connection = new SqlConnection(conectionstring);
                connection.Open();
                constrain = connection.Query<Details>("  exec GetAllCourseDetails; ", conectionstring).ToList();
                connection.Close();

                return constrain;

            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Details> SelectSP(int CourseId)

        {

           List<Details> constrain = new List<Details>();

            var connection = new SqlConnection(conectionstring);
            connection.Open();
            constrain = connection.Query<Details>($"exec [GetCourseDetails] {CourseId}").ToList();
            connection.Close();

            return constrain;
        }



        public void InsertSP(Details a)
        {
            try
            {

                SqlConnection con = new SqlConnection(conectionstring);

                con.Open();
                con.Execute($"exec [InsertAllCourseDetails]  '{a.CourseName}','{a.Duration}','{a.University}','{a.StartDate}',{a.Seats}");

                //con.Execute($"insert into stubio(FirstName,LastName,Age,Email,Gender) values('{a.FirstName}', '{a.LastName}','{a.age}','{a.email}','{a.gender}')");


                con.Close();

            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public void UpdateSP(Details u)
        {
            try
            {
                SqlConnection con = new SqlConnection(conectionstring);


                con.Open();
                con.Execute($"  exec updateCourseDetails '{u.CourseId}','{u.University}' ");



                con.Close();
            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void DeleteSP(int CourseId)
        {
            try
            {
                SqlConnection con = new SqlConnection(conectionstring);


                con.Open();
                con.Execute($"EXEC [DeleteCourseDetails] '{CourseId}'");


                con.Close();
            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}