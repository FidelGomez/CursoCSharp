using ConceptosPOO;

try
{
	Console.WriteLine(new Date(29, 2, 2024));
	Console.WriteLine(new Date(02, 9, 2024));
    Console.WriteLine(new Date(30, 11, 2024));
}
catch (Exception error)
{
	Console.WriteLine(error.Message);
}


Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Juan",
    LastName = "Perez",
    BirthDate = new Date(1, 1, 1980),
    HiringDate = new Date(1, 1, 2010),
    IsActive = true,
    Salary = 1034345600.45M
};

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Lola",
    LastName = "Monita",
    BirthDate = new Date(13, 11, 2001),
    HiringDate = new Date(11, 12, 2020),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F
};

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Miguel",
    LastName = "Lopez",
    BirthDate = new Date(15, 12, 2000),
    HiringDate = new Date(1, 11, 2019),
    IsActive = true,
    Hours = 123.50F,
    HourValue = 320.05M
};

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Luis",
    LastName = "Miguel",
    BirthDate = new Date(20, 05, 2000),
    HiringDate = new Date(13, 12, 2019),
    IsActive = true,
    BaseSalary = 490939.45M,
    Sales = 30000000M,
    CommissionPercentaje = 0.015F
};

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                               ==================");
Console.WriteLine($"Total                          {$"{payroll:C2}",18}");

Invoice invoice = new Invoice()
{
    Description = "RTX 3060 ASUS",
    ID = 1,
    Price = 18000M,
    Quantity = 10
};
Invoice invoice2 = new Invoice()
{
    Description = "AMD RYZEN 5 3600",
    ID = 2,
    Price = 6500M,
    Quantity = 20
};
Console.WriteLine(invoice);
Console.WriteLine(invoice2);
