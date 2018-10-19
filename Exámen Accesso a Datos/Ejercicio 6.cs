using System;

public class Ejercicio_6
{
    public delegate int DelgateOperacion(int x, int y);
    public delegate int DelegateLambda(int x, int y);
    public static int Operation(int num1, int num2, DelegateLambda Operation)
    {
        return Operation(num1, num2);
    }
    class Metodos
    {
        #region Métodos
        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }
        #endregion
    }
}
