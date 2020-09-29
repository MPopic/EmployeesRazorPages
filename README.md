# EmployeesRazorPages
 ASP.NET Core Razor Pages apllication for handling employees  
 
EmployeesRazorPages.Models – This is a .Net standard class library project that contains the models like Employee and Department

EmployeesRazorPages.Services – This is also .Net standard class library project that contains data access services. For data access Entity framework core was used and IemployeeRepository.cs interface abstraction allows us to use dependency injection.

EmployeesRazorPages – This is razor pages web application project. Pages folder Employees contains CRUD operation on employees and coresponding views. In addition to page specific content HeadCountViewComponent.cs was used to display Employee Head Count Summary on several pages in application.

