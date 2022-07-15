namespace OCP.Refactor
{
    abstract class BaseInventario
    {
        protected Producto producto;

        public Producto Producto { get => producto; set => producto = value; }

        public BaseInventario(Producto pProducto)
        {
            producto = pProducto;
        }

        public override string ToString()
        {
            return producto.ToString();
        }

        public abstract double CalcularProducto();

    }
}
