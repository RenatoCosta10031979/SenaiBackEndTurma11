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
            if(Rendimento <=  1500){
                return 0;
            } else if(Rendimento > 1500 && Rendimento <= 3500){
                return Rendimento * 0.02f;
            } else if(rendimento > 3500 && rendimento < 6000){
                return rendimento * 0.035f;
            } else{
                return rendimento * 0.05f;
            }
        }

        // método herdado da interface IPessoaFisica
        public bool ValidarDataNascimento(DateTime dataDeNascimento)
        {
            throw new NotImplementedException();
        }
    }
}