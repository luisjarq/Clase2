class Example
{
    public static void Main()
    {for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"i vale: {i}");
        }
        int valorA = 0;
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine($"i vale: {i}");
        //}

        //int[] array = { 0, 1, 2, 3 };
        List<string> lista = new List<string>() { "gato", "perro" };

        //foreach (string i in lista)
        //{
        //    Console.WriteLine($"i vale: {i}");
        //}
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine($"i vale: {lista[i]}");
        }
    }
}