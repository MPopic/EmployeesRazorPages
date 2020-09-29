using EmployeesRazorPages.Models;
using EmployeesRazorPages.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesRazorPages.ViewComponents
{
    public class HeadCountViewComponent : ViewComponent
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HeadCountViewComponent(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IViewComponentResult Invoke(Dept? departmentName = null)
        {
            var result = _employeeRepository.EmployeeCountByDept(departmentName);

            return View(result);
        }
    }
}
