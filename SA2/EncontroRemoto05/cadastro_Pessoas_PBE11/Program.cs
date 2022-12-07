// caminho para localizar a classe PessoFisica e PessoaJuridica

using System.Globalization;
using System.text.RegularExpressions;
using cadastro_Pessoas_PBE11.Classes;


    
 
novaPf.Nome = "Carlos Drumond de Andrade";
novaPf.Cpf = "13869584688";
novaPf.DataNascimento = new DateTime(2013, 10, 31);
novaPf.Rendimento = 25004.54f;

Endereco endPf = new Endereco();

endPf.Logradouro = "Avenida dos Poetas";
endPf.Numero = 100;
endPf.Complemento = "casa";
endPf.Comercial = false;

novaPf.Endereco = endPf;

PessoaFisica metodosPf = endPf;

Console.clear();

Console.WriteLine(@$"
==============================
|                             |
|     **Pessoa Física**       |
|                             |
==============================
Nome: {novaPf.Nome}
Cpf: {novaPf.Cpf}
Data de nascimento: {novaPf.DataNascimento}
Maior de idade: {(metodosPf.ValidarDataNascimento(novapf.DataNascimento) ? "Sim, maior de idade" : "Não, é menor de idade")}
Maior de idade(string): {(metodosPf.ValidarDataNascimento("05/12/2020") ?  "Sim, maior de idade" : "Não, é menor de idade")}
Rendimento: {novaPf.Rendimento}
Imposto a pagar: {metodosPf.PagarImposto(novaPf.Rendimento).ToString("c", new CultureInfo("pt-BR"))}
Endereço: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.Numero}, {novaPf.Endereco.Complemento}, {novaPf.Endereco.Comercial}
");


//Instaciar o objeto PessoaJuridica
PessoaJuridica novaPj = new PessoaJuridica();

// atribuição de valores para os atributos do objeto
novaPj.RazaoSocial = "Poesia & Cia";
novaPj.cnpj = "83.454.070/0001-47";
novaPj.Rendimento = 1000000.92f;

Endereco endPj = new Endereco();
end.Logradouro = "Rua das flores";
endPj.Numero = 320;
endPj.Complemento = "Poesia & Cia";
endPj.Comercial = true;

novaPj.Endereco = endPj;

PessoaJuridica metodosPj = new PessoaJuridica();
Console.WriteLine(@$"

==============================
|                             |
|     **Pessoa Jurídica**     |
|                             |
==============================
Razão social: {novaPj.RazaoSocial}
Cnpj: {novaPj.Cnpj}
cnpj válido: {(metodosPj.ValidarCnpj(novaPj.cnpj) ? "cnpj válido!" : "cnpj inválido")}
Redimento: {novaPj.Rendimento}
Imposto a pagar: {metodosPj.PagarImposto(novaPj.Rendimento).ToString("c", new CultureInfo("pt-BR))}
Endereço: {novaPJ.Endereco.Logradouro}, {novaPj.Endereco.Numero}, {novaPj.Endereco.Complemento}. {novaPj.Endereco.Comercial}
");

//Exemplo de expressão regular(Regex) para validar um formato de data
// Validação de um formato de data: "DD/MM/AAAA"
string data = "01/11/2022";
bool valido = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");

//Console.WriteLine(valido);

//Exemplo de substring
//string texto = "Ferrari";
//string substring = texto.substring(0, 4);
//Console.WriteLine(substring);





