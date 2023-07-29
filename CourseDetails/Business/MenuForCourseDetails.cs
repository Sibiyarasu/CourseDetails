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
            int d;
            GetCourseInfoRepository obj1 = new GetCourseInfoRepository(); 
            Details obj = new Details();
            

           /* do
            {

                Console.WriteLine("Choose a option");

                Console.WriteLine("1.InsertSP");
                Console.WriteLine("2.ListSP");
                Console.WriteLine("3.UpdateSP");
                Console.WriteLine("4.DeleteSP");
                Console.WriteLine("5.Exit");


                d = Convert.ToInt32(Console.ReadLine());*/


            /*    switch (d)
                {*/
                    /*case 1:


                        var SIBI = obj1.CourseInfo();
                        obj1.Insert  (SIBI);

                        break;

                    case 2:
                        
                        obj1.Select();
                        break;

                    case 3:

                        obj1.updateSP();
                        break;

                    case 4:
                        obj1.deleteSP();
                        break;

                    default:
*/
                      /*  Console.WriteLine("You are choosing a wrong option for CRUD Operation please select the option any one option ");
                        break;

                }

            } while (d != 0);*/


        }
    }
}

    