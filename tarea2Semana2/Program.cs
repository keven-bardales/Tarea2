using System.Collections;
using tarea2Semana2.Clases;

List<Expresion> expresiones = new List<Expresion>();

int a = 10;
int b = 3;
decimal result = (decimal)a / b;
Console.WriteLine(result);

Expresion e1 = new Expresion()
{
    num1 = 20,
    num2 = 10,
};

expresiones.Add(e1);

Expresion e2 = new Expresion()
{

    num1 = 9,
    num2 = 2
};

expresiones.Add(e2);

foreach (Expresion exp in expresiones)
{
    Console.WriteLine($"\nLa suma de {exp.num1} y {exp.num2} es: {exp.suma()}" +
        $"\nLa resta de {exp.num1} y {exp.num2} es: {exp.resta()}" +
        $"\nLa division de {exp.num1} y {exp.num2} es: {exp.division()}" +
        $"\nLa multiplicacion de {exp.num1} y {exp.num2} es: {exp.multiplicacion()}" +
        $"\nEl numero mayor entre {exp.num1} y {exp.num2} es: {exp.maximo()}" +
        $"\nEl numero menor entre {exp.num1} y {exp.num2} es: {exp.minimo()}");
}
