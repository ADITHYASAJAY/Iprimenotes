using AssessmentOnWebApi.Models;

namespace AssessmentOnWebApi
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        List<Student> GetAllStudent();
        List<Student> GetStudentsBySkill(string skill);
        List<Student> GetStudentsByQualification(string skill);
        Student GetStudentById(int studentId);
        void UpdateStudentBySkill(int studentId, string skill);
        void UpdateStudentByQualification(int studentId, string qualification);
        void DeleteStudent(int studentId);
    }
}
