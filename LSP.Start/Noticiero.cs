namespace LSP.Intro
{
    class Noticiero
    {
        protected string mensaje;

        public Noticiero(string pMensaje) => mensaje = pMensaje;

        //primer prueba
        //public void Muestra()
        //{
        //    Console.WriteLine($"Desde el Noticiero {mensaje}");
        //}


        //segunda prueba
        public virtual void Muestra() => Console.WriteLine($"Desde el Noticiero {mensaje}");
       
    }
}
