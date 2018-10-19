using System;

public class Ejercicio_2
{
	public Pregunta2()

    {
            var a = new int[3] { 1, 2, 3 };
            var b = new int[2] { 1, 2 };


            var query = a.Where(i => !b.Contains(i));
            foreach (var x in query)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    
}
