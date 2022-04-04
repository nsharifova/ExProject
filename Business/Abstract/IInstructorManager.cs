using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInstructorManager
    {
        void Add(Instructor instructor);
        void Remove(Instructor instructor);
        void Update(Instructor instructor);
        List<Instructor> GetAll();
        Instructor Get(int id);

    }
}
