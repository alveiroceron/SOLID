namespace SRP.Refactor
{
    class Hacienda
    {
        // Creamos una clase especializada para la otra responsabilidad
        // Ahora cada clase tiene una sola responsabilidad
        public static double CalcularImpuesto(Empleado empleado)
        {
            return empleado.Sueldo * 0.35;
        }

        public static void PagarImpuesto(Empleado empleado)
        {
            double imp = CalcularImpuesto(empleado);

            Console.WriteLine($"se pagó{imp} en impuestos por parte de {empleado.Nombre} ");
        }
    }
}
