//LISKOV 

//objeto de clases hijas deben poder substituir a los objetos de las clases padres sin ocasionar problema
//uso correcto del polimorfismo
//mantenemos funcionalidad de clase padre e hija no se debe perder

//**Ventajas***
//reutilizacion de codigo
//ayuda a mantenimiento




//Primera prueba con new
using LSP.Intro;

Noticiero miNoticiero = new Noticiero("Hola a todos");
miNoticiero.Muestra();

Radio miRadio = new Radio("Como estan..");
miRadio.Muestra();
Console.WriteLine("*********************");


Noticiero sustitucion = new Radio("Probando");
sustitucion.Muestra();


