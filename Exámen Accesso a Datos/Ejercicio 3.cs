using System;

public class Ejercicio_3
{
    public List<int> Par(List<int> lista_llena)
    {
        List<int> List_vacia = new List<int>();
        foreach (int i in lista_llena)
        {
            if (i % 2 == 0)
            {
                List_vacia.Add(i);
            }
        }
        return List_vacia;
    }
    public List<int> Mayores_10(List<int> lista_llena)
    {
        List<int> List_vacia = new List<int>();
        foreach (int i in lista_llena)
        {
            if (i > 10)
            {
                List_vacia.Add(i);
            }
        }
        return List_vacia;
    }
    public List<int> Menores_10(List<int> lista_llena)
    {
        List<int> List_vacia = new List<int>();
        foreach (int i in lista_llena)
        {
            if (i < 10)
            {
                List_vacia.Add(i);
            }
        }
        return List_vacia;
    }

}
