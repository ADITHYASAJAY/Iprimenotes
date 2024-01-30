using AssessmentOnWebApi.Models;

namespace AssessmentOnWebApi.Repository
{
    public interface ICompanyRepository
    {
        void AddCompany(Company company);
        List<Company> GetAllCompanies();
        List<Company> GetCompaniesByCity(string city);

        Company GetCompanyById(int id);
        void DeleteCompany(int id);
    }
}
