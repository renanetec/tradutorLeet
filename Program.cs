using System;

namespace tradutorLeet
{
    class Program
    {
        static void Main(string[] args)
        {
          
          Console.Clear();
           Console.ForegroundColor = ConsoleColor.Red;
           string exercício = @"+---------------+
| Tradutor Leet |
+---------------+";
            
           Console.WriteLine(exercício);
           Console.WriteLine();
           Console.ResetColor();


           Console.BackgroundColor = ConsoleColor.White;
           Console.ForegroundColor = ConsoleColor.Black;
           string mensagem = "TEXTO A SER TRADUZIDO:";
           //1.Digite acima qualquer frase.
           //2.Salve.
           //3.Execute no terminal "dotnet run".
           string novaMensagem = mensagem
           .Replace("e","3")
           .Replace("a","4")
           .Replace("o","0")
           .Replace("t","7")
           .Replace("i","1")
           .Replace("s","5");
          

           Console.WriteLine(novaMensagem);
           Console.WriteLine();
           Console.ResetColor();



        }
    }
}
