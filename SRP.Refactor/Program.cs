using SRP.Refactor;


var empleado = new Empleado("Juan", "developer", 30, 1800000);

Console.WriteLine(empleado);
Console.WriteLine(Hacienda.CalcularImpuesto(empleado));
Hacienda.PagarImpuesto(empleado);

Console.ReadLine();
