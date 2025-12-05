namespace EmployeeManagementSystem;

public class Employee
{
	public int Employeeid { get; set; }
	public string FirstName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;
	public string Email { get; set; }
	public DateTime DateOfBirth { get; set; }
	public Gender Gender { get; set; }
	public int DepartmentId { get; set; }
	public string PhotoPath { get; set; }
}

public enum Gender
{
	Male,
	Female,
	Other
}

public class Department
{
	public int DepartmentId { get; set; }
	public string DepartmentName { get; set; }
}