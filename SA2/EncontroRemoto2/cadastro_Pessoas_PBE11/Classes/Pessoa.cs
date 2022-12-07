using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cadastro_Pessoas_PBE11.Interfaces;

namespace cadastro_Pessoas_PBE11.Classes
{   // classe abstrata que herda de sua interface
    public abstract class Pessoa : IPessoa 
    {
        public string? Nome { get; set; }
        public string? Endereco { get; set; }    
        public float? Rendimento {get; set;}
        // método abstrato herdado da interface
        public abstract float PagarImposto(float Rendimento);
        
    }
}