using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeesRazorPages.Models;
using EmployeesRazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeesRazorPages.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;

        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [TempData]
        public string Message { get; set; }

        public Employee Employee { get; private set; }

        // Model-binding automatically maps the query string id
        // value to the id parameter on this OnGet() method
        public IActionResult OnGet(int id)
        {
            Employee = _employeeRepository.GetEmployee(id);

            if (Employee == null)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }
    }
}