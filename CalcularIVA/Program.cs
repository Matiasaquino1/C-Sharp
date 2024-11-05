namespace EjerciciosTP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al práctico N°2");
            Console.WriteLine("Ingrese el número de ejercicio para ejecutarlo");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1: Calcular IVA de un producto");
            Console.WriteLine("2: Mostrar los numeros del 0-100 no divisibles por 2");
            Console.WriteLine("3: Función de calcular IVA de un producto");
            Console.WriteLine("4: Para salir del programa");
            Console.WriteLine("-------------------------------------------------");
            var ejercicio = Console.ReadLine();

            if (ejercicio.Equals("1"))
            {

                float valorproducto, iva, valortotal;
                Console.WriteLine("Introduce el valor del producto");
                valorproducto = float.Parse(Console.ReadLine());

                iva = valorproducto * 0.21f;
                valortotal = valorproducto + iva;

                Console.WriteLine("El valor del producto es: " + valorproducto);
                Console.WriteLine("el valor del IVA es: " + iva);
                Console.WriteLine("el valor del producto mas IVA es: " + valortotal);

                Console.ReadKey();

            }
            if (ejercicio.Equals("2"))
            {

                int multiplo2;
                multiplo2 = 1;
                while (multiplo2 <= 100)
                {
                    Console.Write(multiplo2);
                    Console.Write('-');
                    multiplo2 = multiplo2 + 2;
                }
                Console.ReadKey();

            }
            if (ejercicio.Equals("3"))
            {
                CalcularIVA();
            }
            if (ejercicio.Equals("4"))
            {
                Console.WriteLine("Saliendo...");
                return;
            }

        }

        public static void CalcularIVA()
        {

            float valorproducto, iva, valortotal;
            Console.WriteLine("Introduce el valor del producto");
            valorproducto = float.Parse(Console.ReadLine());

            iva = valorproducto * 0.21f;
            valortotal = valorproducto + iva;

            Console.WriteLine("el valor del producto mas IVA es: " + valortotal);

            Console.ReadKey();
        }

    }
}







