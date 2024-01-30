using AssessmentOnWebApi.Models;

namespace AssessmentOnWebApi.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        List<Company> companies = new List<Company>();
        public void AddCompany(Company company)
        {
            try 
            {
                companies.Add(company);
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteCompany(int id)
        {
            try 
            {
                foreach (Company company in companies) 
                {
                    if (company.CompanyId == id) 
                    {
                        companies.Remove(company);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Company> GetAllCompanies()
        {
            try 
            {
                return companies;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Company> GetCompaniesByCity(string city)
        {
            try 
            {
                List<Company> companiesInSameCity = new List<Company>();
                foreach (Company company in companies) 
                {
                    if(company.City == city) 
                    {
                        companiesInSameCity.Add(company);
                    }
                }
                return companiesInSameCity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Company GetCompanyById(int id)
        {
            try 
            {
                Company company = new Company();
                foreach(var c in companies)
                {
                    if(c.CompanyId == id) 
                    {
                        company = c;
                        break;
                    }
                }
                return company;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
