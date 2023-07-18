using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseDetails.Model;

using System.Data.SqlClient;
using Dapper;
namespace CourseDetails.Repository
{
    class GetCourseInfoRepository
    {
        

            public readonly string conectionstring;

            

            public Details CourseInfo()
            {

                Details s = new Details();

                Console.WriteLine("Enter Course Name");
                s.CourseName = Console.ReadLine();

                Console.WriteLine("Enter  Duration");
                s.Duration = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name of the University");
                s.University = Console.ReadLine();


                Console.WriteLine("Enter the course Start Date");
                s.StartDate = Console.ReadLine();


                Console.WriteLine("Enter  the Number of seats Available");
                s.Seats = Convert.ToInt32(Console.ReadLine());
                return s;
            }

            public GetCourseInfoRepository()
            {

                conectionstring = @"Data source=DESKTOP-TKPKUBE\SQLEXPRESS;Initial catalog=SQL QUERIES;User Id=sa;Password=Anaiyaan@123";
            }

            public void Insert(Details A

        )
            {
                try
                {

                    SqlConnection con = new SqlConnection(conectionstring);

                    con.Open();
                    con.Execute($"exec InsertAllCourseDetails '{A.CourseName}',{A.Duration},'{A.University}','{A.StartDate}',{A.Seats}");

                    con.Close();

                }
                catch (SqlException ep)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<Details> Select()

            {

                try

                {

                    List<Details> c = new List<Details>();
                    var connection = new SqlConnection(conectionstring);
                    connection.Open();
                    c = connection.Query<Details>("select * from CourseDetailsInfo").ToList();

                    connection.Close();
                    foreach (var a in c)
                    {
                        Console.WriteLine($" CourseId-{a.CourseId} ,Course Name - {a.CourseName }, Duration  - {a.Duration},  University  - {a.University} , Starting Date is - {a.StartDate}, Number of Seats Available - {a.Seats}");
                    }

                    return c;
                }

                catch (Exception ex)

                {

                    throw ex;

                }
            }

        }
    } 
