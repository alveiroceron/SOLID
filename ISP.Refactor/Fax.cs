namespace ISP.Refactor
{
    internal class Fax:IFax
    {

        //implementamos solo los metodos que si necesitamos
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
