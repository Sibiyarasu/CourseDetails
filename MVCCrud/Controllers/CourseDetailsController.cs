using CourseDetails.Model;
using CourseDetails.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCrud.Controllers
{
    public class CourseDetailsController : Controller
    {
        GetCourseInfoRepository obj = new GetCourseInfoRepository();
        public CourseDetailsController()
        { }
        // GET: CourseDetailsController


        public ActionResult List()
        {
            return View("ListCourseDetails",new List<Details>(obj.SelectSP()));
        }

        // GET: CourseDetailsController/Details/5
        public ActionResult Details(int Courseid)
        {

            var res = obj.SelectSP(Courseid);
            return View("details",res);
        }

        // GET: CourseDetailsController/Create
        public ActionResult Create()
        {
            return View("CreateCourseDetails", new Details());
        }

        // POST: CourseDetailsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Details res)
        {
            try
            {
                obj.InsertSP(res);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseDetailsController/Edit/5
        public ActionResult Edit(int Courseid)
        {

            var res = obj.SelectSP(Courseid);
            return View("Update",res);
        }

        // POST: CourseDetailsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int CourseId, Details res)
        {
            try
            {

                res.CourseId = CourseId;
                obj.UpdateSP(res);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseDetailsController/Delete/5
        public ActionResult Delete(int Courseid)
        {

            var result = obj.SelectSP(Courseid);

            return View("Delete",result);
        }

        // POST: CourseDetailsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(int Courseid)
        {
            try
            {
                obj.DeleteSP(Courseid);

                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
