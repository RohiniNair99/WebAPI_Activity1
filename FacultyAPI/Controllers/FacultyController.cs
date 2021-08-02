using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FacultyAPI.Models;

namespace FacultyAPI.Controllers
{
    public class FacultyController : ApiController
    {
        // GET: api/Faculty
        public List<string> Get()
        {
            List<Faculty> facultyList = new List<Faculty>();
            List<string> facultyPrint = new List<string>();
            using (ConnectFaculty connect = new ConnectFaculty())
            {
                facultyList = connect.Faculties.ToList();
                
            }
            foreach(Faculty faculty in facultyList )
            {
                facultyPrint.Add($"{faculty.PSNO}  {faculty.FacultyName}  {faculty.EmailId}");
            }
            return facultyPrint;
        }

       
    }
}
