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

Console.WriteLine(employee1);
Console.WriteLine(employee2);

