// See https://aka.ms/new-console-template for more information
string path = @"C:\Users\lclui\Desktop\ejemplo.txt";
string[] arrayDeTexto = File.ReadAllLines(path);
List<string> lineasDeTexto = new List<string>(arrayDeTexto);
int contador = 0;
foreach (string linea in lineasDeTexto)
{
    string[] palabras = linea.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    foreach (string palabra in palabras)
    {
        if (palabra == "Cervantes")
        {
            contador++;
        }
    }
}
Console.WriteLine(contador);



