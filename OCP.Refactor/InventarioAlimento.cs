namespace OCP.Refactor
{
    class InventarioAlimento : BaseInventario
    {
        public InventarioAlimento(Producto pProducto) : base(pProducto)
        {

        }


        public override double CalcularProducto()
        {           
            producto.Precio *= 1.2;
            return producto.Precio;
        }
    }
}
