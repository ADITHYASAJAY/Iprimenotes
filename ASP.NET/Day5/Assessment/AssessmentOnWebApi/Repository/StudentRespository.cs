using AssessmentOnWebApi.Models;

namespace AssessmentOnWebApi.Repository
{
    public class StudentRespository : IStudentRepository
    {
        List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
            try 
            {
                students.Add(student);
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteStudent(int studentId)
        {
            try 
            {
                foreach (Student student in students) 
                {
                    if(student.StudentId==studentId)
                    {
                        students.Remove(student);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Student> GetAllStudent()
        {
            try 
            {
                return students;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Student GetStudentById(int studentId)
        {
            try 
            {
                Student studentById = new Student();
                foreach(Student student in students) 
                {
                    if (student.StudentId == studentId) 
                    {
                        studentById = student;
                        break;
                    }
                }
                return studentById;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Student> GetStudentsByQualification(string qualification)
        {
            try 
            {
                List<Student> studentsByQualification = new List<Student>();
                foreach(Student student in students) 
                {
                    if (student.Qualification.Equals(qualification)) 
                    {
                        studentsByQualification.Add(student);
                    }
                }
                return studentsByQualification;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Student> GetStudentsBySkill(string skill)
        {
            try 
            {
                List<Student> studentsBySkill = new List<Student>();
                foreach (Student student in students)
                {
                    if (student.Skill.Equals(skill))
                    {
                        studentsBySkill.Add(student);
                    }
                }
                return studentsBySkill;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateStudentByQualification(int studentId,string qualification)
        {
            try 
            { 
                foreach(Student student in students) 
                {
                    if(student.StudentId==studentId)
                    {
                        student.Qualification = qualification;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateStudentBySkill(int studentId, string skill)
        {
            try 
            {
                foreach (Student student in students)
                {
                    if (student.StudentId == studentId)
                    {
                        student.Skill = skill;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
