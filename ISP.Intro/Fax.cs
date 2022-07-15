namespace ISP.Intro
{
    internal class Fax:IMultifuncional
    {

        //nos vemos forzados a implementar estos servicios
        public void Imprimir()
        {
            Console.WriteLine("No tengo este servicio");
        }

        public void Escanear()
        {
            Console.WriteLine("No tengo este servicio");
        }

        //estos metodos si necesitamos
        public void Faxear()
        {
            Console.WriteLine("Envio un fax");
        }

        public void Telefono()
        {
            Console.WriteLine("Te marco a un teléfono");
        }
    }
}
