using Business.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorManager:IInstructorManager
    {
        private readonly IInsctuctorDal _dal;

        public InstructorManager(IInsctuctorDal dal)
        {
            _dal = dal;
        }


        public void Add(Instructor instructor)
        {
            Instructor ins = new()
            {
                Fullname = instructor.Fullname,
                ProfileImage=instructor.ProfileImage,
                StudentCount=instructor.StudentCount,

            };

            _dal.Add(ins);
          

        }

        public Instructor Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetAll()
        {
            return _dal.GetAll(null);
        }

        public void Remove(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public void Update(Instructor instructor)
        {
            throw new NotImplementedException();
        }
    }
}
