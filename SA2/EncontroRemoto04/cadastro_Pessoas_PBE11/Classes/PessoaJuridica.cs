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
        public bool ValidarCnpj(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}