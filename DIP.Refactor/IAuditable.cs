namespace DIP.Refactor
{
    interface IAuditable
    {
        IEnumerable<Producto> ObtenProductos(int pTipo);
    }
}
