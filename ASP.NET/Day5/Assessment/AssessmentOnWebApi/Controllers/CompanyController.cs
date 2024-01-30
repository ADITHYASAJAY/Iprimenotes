using AssessmentOnWebApi.Models;
using AssessmentOnWebApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentOnWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        ICompanyRepository companyRepository;
        public CompanyController(ICompanyRepository companyRepository) 
        {
            this.companyRepository = companyRepository;
        }
        [HttpPost,Route("AddCompany")]
        public IActionResult AddCompany(Company company)
        {
            try 
            {
                companyRepository.AddCompany(company);
                return StatusCode(200,company);
            }
            catch(Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet, Route("GetAllCompanies")]
        public IActionResult GetAllCompanies()
        {
            try 
            {
                var companies = companyRepository.GetAllCompanies();
                return StatusCode(200, companies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet, Route("GetCompanyById/{id}")]
        public IActionResult GetCompanyById(int id)
        {
            try 
            {
                var company = companyRepository.GetCompanyById(id);
                return StatusCode(200, company);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet, Route("GetCompaniesByCity/{city}")]
        public IActionResult GetCompaniesByCity(string city)
        {
            try 
            {
                var companies = companyRepository.GetCompaniesByCity(city);
                return StatusCode(200, companies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete,Route("DeleteCompany/{id}")]
        public IActionResult DeleteCompany(int id)
        {
            try 
            {
                companyRepository.DeleteCompany(id);
                return StatusCode(200, "Deleted Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
