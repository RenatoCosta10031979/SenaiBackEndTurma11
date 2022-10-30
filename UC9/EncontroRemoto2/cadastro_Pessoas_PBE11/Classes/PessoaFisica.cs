using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cadastro_Pessoas_PBE11.Interfaces;

namespace cadastro_Pessoas_PBE11.Classes
{   
    //classe PessoaFisica que her da classe abstrata e de sua interface
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        //atributos
        public string? Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        //metodos herdado como sobrescrita da classe abstrata Pessoa
        public override float PagarImposto(float Rendimento)
        {
            throw new NotImplementedException();
        }

        // método herdado da interface IPessoaFisica
        public bool ValidarDataNascimento(DateTime dataDeNascimento)
        {
            throw new NotImplementedException();
        }
    }
}