namespace Refactoring.SalaryTax.Problem;

public class Employee
{
	public Employee(int id, string name, Role role, DateTime admissionDate, double baseSalary)
	{
		Id = id;
		Name = name;
		Role = role;
		AdmissionDate = admissionDate;
		BaseSalary = baseSalary;
	}

	public int Id { get; private set; }
	public string Name { get; private set; }
	public Role Role { get; private set; }
	public DateTime AdmissionDate { get; private set; }
	public double BaseSalary { get; private set; }
}
