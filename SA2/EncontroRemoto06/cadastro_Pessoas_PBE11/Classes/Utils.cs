

namespace cadastro_Pessoas_PBE11.Classes
{
    static class Utils
    {
        public static void BarraDeCarregamento(string texto, int tempo, int quantidade)
        {
                
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write($"Iniciando");

            for (int contador = 0; contador < quantidade; contador++)
            {
                Console.Write($".");
                Thread.sleep(tempo);
            }

            Console.ResetColor();

        }
    }
}