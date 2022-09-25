
using System;
//namespace System,IO - contém tipos que permitem a leitura e escrita em arquivos
using System.IO;

namespace teste
{
    class Program 
    {
        static void Main(string[] args)
        {
            // caminho do arquivo
            string caminhodoArquivo = "/home/cafecomjava/Documents/teste/arquivo.txt";
            
            // utilizado para escrever data em um arquivo
            var stream = new StreamWriter(caminhodoArquivo);

            //escreve uma linha no arquivo
            stream.Write("Curso Qualificação profissional Back-End.\n.PBE_UC9_SA2:Codificação para Back-End-turma 11.\n\nO texto foi salvo com sucesso! :)");

            // fecha o objeto atual e o fluxo adjacente
            stream.Close();

            // O using finaliza a instrução no final do bloco que a execução
            // streamreader para ler um arquivo
            using(var reader = new StreamReader(caminhodoArquivo))
            {
                // Lê a linha e retorna a string
                Console.WriteLine(reader.ReadLine());
            }
            
            
        }
    }
}
    

