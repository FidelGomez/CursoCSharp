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

