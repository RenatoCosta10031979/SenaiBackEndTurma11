// caminho para localizar a classe PessoFisica e PessoaJuridica
using cadastro_Pessoas_PBE11.Classes;

//Instaciar objeto PessoaFisica
PessoaFisica novaPf = new PessoaFisica();

// atribuição de valores para os atributos do objeto
novaPf.Nome = "Fernando Pessoa";
novaPf.Rendimento =  7456.67f;

//Imprimir no console com Concatenação
Console.WriteLine("Nome: " + novaPf.Nome);
Console.WriteLine("Rendimento: " + novaPf.Rendimento +" "+ "reais");

//Instaciar o objeto PessoaJuridica
PessoaJuridica novaPj = new PessoaJuridica();

// atribuição de valores para os atributos do objeto
novaPj.RazaoSocial = "Poesia & Cia";

// Imprimir no console com interpolação
Console.WriteLine($"Nome social: {novaPj.RazaoSocial}");
