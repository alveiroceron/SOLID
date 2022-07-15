//segregar es dividir las interfaces para que se implementen los quellos metodos que son necesarios
//si usamos interfaces con multiples propositos vamos a tener clases con metodos que no son usados
//interfaces pequeñas evita metodos vacios es decir menos implementaciones 
//lectura de codigo facil y facil mantenimiento


using ISP.Intro;

var avanzado = new MultiAvanzado();
avanzado.Escanear();
avanzado.Faxear();
avanzado.Imprimir();
avanzado.Telefono();
Console.WriteLine("*****************");

var miFax = new Fax();
miFax.Telefono();
miFax.Faxear();
miFax.Imprimir();
Console.WriteLine("*****************");

var sencillo = new MultiSencillo();
sencillo.Escanear();
sencillo.Imprimir();
sencillo.Telefono();  //lanza excepcion


