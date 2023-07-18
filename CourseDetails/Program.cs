using System;
using CourseDetails.Business;
namespace CourseDetails
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                MenuForCourseDetails obj = new MenuForCourseDetails();
                    obj.StoredProcedure();
            }

            catch(Exception ex)
            {
                throw;
            }
                }
    }
}
