namespace ISP.Refactor
{
    internal class MultiSencillo : IMultiBasico
    {
        //necesitamos estos metodos

        public void Imprimir()
        {
            Console.WriteLine("imprimo tu documento");
        }
        public void Escanear()
        {
            Console.WriteLine("Estoy escaneando una foto");
        }

   
    }
}
