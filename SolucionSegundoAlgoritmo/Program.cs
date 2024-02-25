internal class Program
{
    private static void Main(string[] args)
    {
        //Problema: Realizar un algoritmo que me pida 3 números por pantalla, con el primer número hallar el cuadrado
        //con el segundo número hallar la raíz cuadrada y con el tercer número hallar la raíz cúbica
        //Mostrar en pantalla los 3 resultados aritméticos. Recuerde concatenar bien los strings para mostrar un buen mensaje

        //Como primero declaramos variables, en este caso tenemos 3 números y tenemos 3 operaciones, por lo cuál serán 6 variables
        double num1, num2, num3;
        double cuadrado, raiz2, raiz3;

        //Imprimimos las entradas de los números
        Console.Write("Ingrese su primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese su segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese su tercer número: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        //Definimos las operaciones aritméticas

        cuadrado = num1 * num1;
        raiz2 = Math.Pow(num2, 0.5);
        raiz3 = Math.Pow(num3, 0.3333333333333);
        

        //Imprimimos los resultados por la consola

        Console.WriteLine("El Cuadrado de " + num1 + " es: " + cuadrado);
        Console.WriteLine("La raíz cuadrada de " + num2 + " es: " +  raiz2);
        Console.WriteLine("La raíz cúbica de " + num3 + " es : " + raiz3);
    }
}