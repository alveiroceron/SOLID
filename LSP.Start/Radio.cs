namespace LSP.Intro
{
    internal class Radio : Noticiero
    {

        public Radio(string pMensaje):base(pMensaje)
        {

        }

        //primer prueba
        //public new void Muestra()
        //{
        //    Console.WriteLine($"Desde el Radio {mensaje}");
        //}

        //segunda prueba
        public override void Muestra() =>  Console.WriteLine($"Desde el Radio {mensaje}");
        

        //al hacer override se pierde funcionalidad de la clase padre
    }
}
