// See https://aka.ms/new-console-template for more information


using ISP.Refactor;

var avanzado = new MultiAvanzado();
avanzado.Escanear();
avanzado.Faxear();
avanzado.Imprimir();
avanzado.Telefono();
Console.WriteLine("*****************");

var miFax = new Fax();
miFax.Telefono();
miFax.Faxear();
Console.WriteLine("*****************");

var sencillo = new MultiSencillo();
sencillo.Escanear();
sencillo.Imprimir();



