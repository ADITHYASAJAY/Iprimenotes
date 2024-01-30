using HandsOnEFCodeFirst_Demo2.Entities;

namespace HandsOnEFCodeFirst_Demo2.Repository
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly MyContext _context;
        public StudentRepository(MyContext _context)
        {
            this._context = context;
        }
        public void Add(Student entity)
        {
           _context.Students.Add(entity);   
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Student student = _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public Student Get(int id)
        {
            Student student = _context.Students.Find(id);
            return student;
        }

        public List<Student> GetAll()
        {
            return  _context.Students.ToList(); 
        }

        public void Update(Student entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
