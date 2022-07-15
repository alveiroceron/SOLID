// See https://aka.ms/new-console-template for more information

using SRP.Intro;

var empleado = new Empleado("Juan", "developer", 30, 1800000);


Console.WriteLine(empleado);
empleado.PagarImpuesto();
Console.ReadLine();
