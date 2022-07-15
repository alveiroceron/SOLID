namespace ISP.Intro
{
    internal class MultiSencillo : IMultifuncional
    {
        //necesitamos estos metodos
        public void Escanear()
        {
            Console.WriteLine("Estoy escaneando una foto");
        }

        public void Imprimir()
        {
            Console.WriteLine("imprimo tu documento");
        }

        //estos metodos no los necesitamos
        // si no los implementamos hay que poner excepcion

        public void Telefono()
        {
            throw new NotImplementedException();
        }

        public void Faxear()
        {
            throw new NotImplementedException();
        }

 
    }
}
