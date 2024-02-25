public class Program
{
    private static void Main(string[] args)
    {
        // Ingresar dos números por pantalla y calcular las 4 operaciones aritméticas con dichos números.
        // Mostrar en pantalla un mensaje de advertencia que indique que el segundo número debe ser diferente de 0.
        // Imprimir en pantalla el resultado de cada operación

        // Declaramos las variables que vamos a usar.
        double num1, num2;
        double sum, dif, prod, div;

        //Leer
        Console.Write("Ingrese su primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Ingrese su segundo número, este número debe ser diferente a 0: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        //Hacer las operaciones Aritméticas
        sum = num1 + num2;
        dif = num1 - num2;
        prod = num1 * num2;
        div = num1 / num2;

        //Imprimir los resultados
        Console.WriteLine("El serultado de la suma es: " + sum);
        Console.WriteLine();
        Console.WriteLine("El serultado de la resta es: " + dif);
        Console.WriteLine();
        Console.WriteLine("El serultado del producto es: " + prod);
        Console.WriteLine();
        Console.WriteLine("El serultado de la división es: " + div);

    }
}