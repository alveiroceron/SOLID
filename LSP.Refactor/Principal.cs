namespace LSP.Refactor
{
    abstract class Principal
    {
        protected string mensaje;
        public Principal(string pMensaje) => mensaje = pMensaje;


        //creamos el metodo como abstracto para que cada version lo implemente. y no se cambie el comportamiento
        public abstract void Muestra(); 

    }
}
