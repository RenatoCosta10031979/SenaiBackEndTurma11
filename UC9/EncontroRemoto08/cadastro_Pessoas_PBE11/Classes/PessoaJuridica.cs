using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cadastro_Pessoas_PBE11.Classes;

namespace cadastro_Pessoas_PBE11.Classes
{
    //classe pessaJuridica que herda da classe abstrata e de sua interface
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        //atributos
        public String? RazaoSocial { get; set; }
        public String? Cnpj { get; set; }

        private string Caminho { get; set; } = "Database/PessoaJuridica.csv";

        //método herdado como sobrescrita da classe abstrata Pessoa
        public override float PagarImposto(float Rendimento)
        {
            if( Rendimento <= 3000){
                return Rendimento * 0.03f;
            } else if(Rendimento > 3000 && Rendimento <= 6000){
                return rendimento * 0.05f;
            } else if( Rendimento > 6000 && Rendimento < 10000){
                return Rendimento * 0.07f;
            } else{
                return Rendimento * 0.09f;
            }
            
            }
        }
        // método herdado da Interface IPessoaJuridica
        public bool ValidarCnpj(string cnpj)
        {
            if(Regex.IsMatch(cnpj, @"(^(\{2}.\d{3}.\d{3}/\d{4}-\d{2}) | (\d{14})$)"))
            {
                    if (cnpj.length == 18)
                    {
                        if (cnpj.Substring(11, 4) == "0001")
                        {
                            return true;
                        }
                    }
                    else if ( cnpj.length == 14)
                    {
                        if (cnpj.Substring(8, 4))
                        {
                            return true;
                        }
                    }
            }
            return false;
        }

        // método par ainserir um objeto de pessoa jurídica em um arquivo csv

        public void Inserir(PessoaJuridica pJ)
        {
            Utils.VerificarPastaArquivo(caminho);

            string[] pJStrings = {$"{pJ.Nome}, {pj.Cnpj}, {pJ.RazaoSocial}}"};

            File.AppendAllLines(Caminho, pJStrings);
        }

        //Método para ler arquivos armazenados em um arquivo csv
        public List<PessoaJuridica> lerArquivo()
        {
            listPf<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(Caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");
                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.Nome = atributos[0];
                cadaPj.Cnpj = atributos[1];
                cadaPj.RazaoSocial = atributos[2];

                listaPj.Add(cadaPj);
            }

            return listaPj;
        }




    }
}