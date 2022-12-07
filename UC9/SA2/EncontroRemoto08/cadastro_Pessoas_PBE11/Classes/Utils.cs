

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
        // método verifica se o caminho existe : "Database/PessoaJuridica.csv"
        public static void VerificarPastaArquivo(string caminho)
        {
            // variável que vai receber a posição 0 do meu caminho("Database")
                string pasta = caminho.Split("/")[0];

                if(!Directory.Exists(pasta))
                {
                    Directory.createDirectory(pasta);
                }

                if (file.Exists(caminho))
                {
                    File.Create(caminho);
                }
        }
    }
}