using System;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class SqlServerDb : IStudentsDb
    {
        public IEnumerable<Student> GetStudents()
        {
            throw new NotImplementedException();
        }
    }
}
