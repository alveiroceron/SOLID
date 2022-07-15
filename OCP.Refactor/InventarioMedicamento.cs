namespace OCP.Refactor
{
    class InventarioMedicamento : BaseInventario
    {
        public InventarioMedicamento(Producto pProducto) : base(pProducto)
        {

        }


        public override double CalcularProducto()
        {           
            producto.Precio *= 0.8;
            return producto.Precio;
        }
    }
}
