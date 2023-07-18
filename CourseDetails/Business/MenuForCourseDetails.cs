using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseDetails.Repository;
using CourseDetails.Model;

namespace CourseDetails.Business
{
    class MenuForCourseDetails
    {
        public void StoredProcedure()
        {
            int a;
            GetCourseInfoRepository obj1 = new GetCourseInfoRepository();
            Details obj = new Details();
            

            do
            {

                Console.WriteLine("Choose a option");

                Console.WriteLine("1.InsertSP");
                Console.WriteLine("2.ListSP");
                Console.WriteLine("3.Exit");


                a = Convert.ToInt32(Console.ReadLine());


                switch (a)
                {
                    case 1:


                        var SIBI = obj1.CourseInfo();
                        obj1.
                            (SIBI);
                        break;

                    case 2:
                        
                        obj1.Select();
                        break;

                    default:

                        Console.WriteLine("You are choosing a wrong option for CRUD Operation please select the option any one option ");
                        break;

                }

            } while (a != 0);


        }
    }
}

    