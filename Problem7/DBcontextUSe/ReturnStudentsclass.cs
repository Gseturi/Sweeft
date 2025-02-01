using SweeftEFCodefirst.Context;
using static SweeftEFCodefirst.Models.SchoolModels;

namespace SweeftEFCodefirst.DBcontextUSe
{
    internal class ReturnStudentsclass
    {
        SchoolDbcontext _context;
        public ReturnStudentsclass(SchoolDbcontext context)
        {
            _context = context;
        }



        public Teacher[] GetAllTeacherifGIO()
        {
            return _context.TeacherPupils
          .Where(tp => tp.Pupil.FirstName == "გიორგი")
          .Select(tp => tp.Teacher)
          .ToArray();


        }

        public Teacher[] GetAllTeachersByStudent(string studentName)
        {
            return _context.TeacherPupils
                .Where(tp => tp.Pupil.FirstName == studentName)
                .Select(tp => tp.Teacher)
                .ToArray();
        }
    }
}
