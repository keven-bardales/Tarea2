using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2Semana2.Clases
{
    public class Expresion
    {

    public int num1 { get; set; }
    public int num2 { get; set; }
    
    public int suma()
        {
            return num1 + num2;
        }

    public int resta()
        {
            return num1 - num2;
        }

    public double division()
        {
            return (double)num1 / num2;
        }

    public int multiplicacion()
        {
            return num1 * num2;
        }

    public int maximo()
        {
            if(num1 > num2)
            {
                return num1;
            }else
            {
                return num2;
            }
        }

    public int minimo()
        {
            if(num1 < num2)
            {
                return num1;
            }else
            {
                return num2;
            }
        }

    public string mostrarExpresion()
        {
            return $"\nSuma de {num1} y {num2} es: {suma()}" +
                $"\nResta de {num1} y {num2} es: {resta()}" +
                $"\nDivision de {num1} y {num2} es: {division()}" +
                $"\nMultiplicacion de {num1} y {num2} es: {multiplicacion()}" +
                $"\nEl numero mayor entre {num1} y {num2} es: {maximo()}" +
                $"\nEl numero menor entre {num1} y {num2} es: {minimo()}";
        }

    }

   
}
