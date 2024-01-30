using HandsOnAPIUsingModels.Models;
using HandsOnAPIUsingModels.Repositories;

namespace HandsOnAPIUsingModels.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        static List<Teacher> teachers = new List<Teacher>();
        public void Add(Teacher teacher)
        {
            try 
            {
                teachers.Add(teacher);
            } 
            catch(Exception ) 
            {
                throw;
            }
            
        }

        public void Delete(int id)
        {
            try 
            {
               foreach(var item in teachers) 
                {
                    if (item.Id == id) 
                    {
                        teachers.Remove(item);
                        break;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Teacher> GetAll()
        {
            try {
                return teachers;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public Teacher GetTeacher(int id)
        {
            try 
            {
                foreach (var item in teachers)
                {
                    if (item.Id == id)
                    {
                        return item;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Teacher> GetTeacherBySubject(string subject)
        {
            List<Teacher> teachersBySubject = null;
            try {
                foreach (var item in teachers)
                {
                    if (item.Subject == subject)
                    {
                        teachersBySubject.Add(item);
                    }
                }
                return teachersBySubject;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Teacher teacher)
        {
            try 
            {
                foreach (var item in teachers)
                {
                    if (item.Id == teacher.Id)
                    {
                        item.Stds = teacher.Stds;
                        item.Name = teacher.Name;
                        item.Subject = teacher.Subject;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

      

       
    }
}
