//lea la cordenada entre dos puntos y calcule su distancia

//Definimos variables
int x1, y1, x2, y2;
int restay, restax;
double cuadradox, cuadradoy;
int sumacuadrados;
double raiz;

//Ingresamos los números que queremos operar
Console.WriteLine("Ingrese un valor para X1: ");
x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese un valor para Y1: ");
y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese un valor para X2: ");
x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese un valor para Y2: ");
y2 = Convert.ToInt32(Console.ReadLine());

//Mostrar los pares ordenados
Console.WriteLine("(" + x1 + "," + y1 + ") " + "(" + x2 + "," + y2 + ")");

//Definir operaciones
restax = x2 - x1;
restay = y2 - y1;
cuadradox = Math.Pow(restax, 2);
cuadradoy = Math.Pow(restay, 2);
sumacuadrados = (int)cuadradox + (int)cuadradoy;
raiz = Math.Pow(sumacuadrados, 0.5);

//Imprimir valor final
Console.WriteLine("La distancia entre los puntos es: " + raiz);







