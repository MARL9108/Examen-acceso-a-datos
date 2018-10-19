using System;

public class Ejercicio_4
{
    public int DevolverMax(List<int> list)
    {
        var num =
                (from i in list select i).Max();

        return num;
    }
}
