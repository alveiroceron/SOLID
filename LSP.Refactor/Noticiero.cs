namespace LSP.Refactor
{
    class Noticiero: Principal
    {
        protected string mensaje;

        public Noticiero(string pMensaje) : base(pMensaje)
        {
            mensaje = pMensaje;
        }
       


        //segunda prueba
        public override void Muestra() => Console.WriteLine($"Desde el Noticiero {mensaje}");

    }
}
