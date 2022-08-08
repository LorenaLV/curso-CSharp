// See https://aka.ms/new-console-template for more information

/*Ejercicio 1
Escribe un programa que reciba tu nombre y lo escriba por consola.
*/
Console.WriteLine("Escribe tu nombre: ");
string name = "Lorena";
Console.WriteLine("Hola, " + name);

/* Ejercicio 2
 Escribe un programa que tome la hora y la escriba por pantalla.
 */
Console.WriteLine("Dime la hora actual");
string hora = Console.ReadLine();
Console.WriteLine("Esta es la hora actual: " + hora);

Console.WriteLine("Dime tu edad");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Tu edad es: " + edad);

/*int i = 0;
long l = 1;
float f = 10.33234f;
double d = 2.3d;
char c = 'a';
string str = "string";

Console.WriteLine("int: " + i);
Console.WriteLine("long: " + l);
Console.WriteLine("float: " + f);
Console.WriteLine("double: " + d);
Console.WriteLine("char: " + c);
Console.WriteLine("str: " + str);
*/