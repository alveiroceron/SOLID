namespace DIP.Refactor
{
    //clase alto nivel
    class Auditor
    {
        private IAuditable miAlmacen;

        //ahora auditor ya no esta fuertemente acoplado con el almacen
        public Auditor(IAuditable pAlmacen)
        {
            miAlmacen = pAlmacen;
        }

        public double TotalesAlimentos()
        {
            double total = 0;

            var products = miAlmacen.ObtenProductos(0); //tipo 0 alimentos

            foreach (var p in products)
            {            
                Console.WriteLine(p);
                total += p.Costo;               
            }
            return total;
        }
    }
}
