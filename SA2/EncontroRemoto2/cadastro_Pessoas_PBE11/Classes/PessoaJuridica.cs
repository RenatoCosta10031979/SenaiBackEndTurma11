using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cadastro_Pessoas_PBE11.Interfaces;

namespace cadastro_Pessoas_PBE11.Classes
{
    //classe pessaJuridica que herda da classe abstrata e de sua interface
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        //atributos
        public String? RazaoSocial { get; set; }
        public String? Cnpj { get; set; }

        //método herdado como sobrescrita da classe abstrata Pessoa
        public override float PagarImposto(float Rendimento)
        {
            throw new NotImplementedException();
        }
        // método herdado da Interface IPessoaJuridica
        public bool ValidarCnpj(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}