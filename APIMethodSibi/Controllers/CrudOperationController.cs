using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseDetails.Repository;
using CourseDetails.Business;
using CourseDetails.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIMethodSibi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudOperationController : ControllerBase
    { 
        public GetCourseInfoRepository obj;
        public CrudOperationController()
        {
            obj = new GetCourseInfoRepository();
        }



        // GET: api/<CrudOperationController>
        [HttpGet]
        public IEnumerable<Details> Get()
        {
            return obj.SelectSP();
        }





        // GET api/<CrudOperationController>/5
        [HttpGet("{CourseId}")]
        public IEnumerable<Details> Get(int CourseId)
        {
            return obj.SelectSP(CourseId);
        }




        // POST api/<CrudOperationController>
        [HttpPost]
        public void Post([FromBody] Details value)
        {
            obj.InsertSP(value);

        }



        // PUT api/<CrudOperationController>/5
        [HttpPut("{Courseid}")]
        public void Put(int Courseid, [FromBody] Details value)
        {
            value.CourseId = Courseid;
            obj.UpdateSP(value);
        }



        // DELETE api/<CrudOperationController>/5
        [HttpDelete("{Courseid}")]
        public void Delete(int Courseid)
        {
            obj.DeleteSP(Courseid);

        }
    }
}
