using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FacultyAPI.Models;

namespace FacultyAPI.Controllers
{
    public class CourseController : ApiController
    {
        // GET: api/Course
        public List<string> Get()
        {
            List<Cours> courseList = new List<Cours>();
            List<string> coursePrint = new List<string>();
            using (ConnectFaculty connect = new ConnectFaculty())
            {
                courseList = connect.Courses.ToList();

            }
            foreach (Cours course in courseList)
            {
                coursePrint.Add($"{course.CourseId}  {course.CourseTitle}  {course.CourseDuration}  {course.CourseMode} ");
            }
            return coursePrint;
        }

    }
}