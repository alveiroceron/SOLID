namespace LSP.Refactor
{
    internal class Radio : Principal
    {
        public Radio(string pMensaje):base(pMensaje)
        {

        }

        public override void Muestra() =>  Console.WriteLine($"Desde el Radio {mensaje}");
        
    }
}
