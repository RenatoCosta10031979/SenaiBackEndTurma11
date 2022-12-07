// caminho para localizar a classe PessoFisica e PessoaJuridica
using System.Globalization;
using System.text.RegularExpressions;
using cadastro_Pessoas_PBE11.Classes;


Console.WriteLine(@$"

=====================================================
|         ****Bem vindo ao sistema de***            |
|  cadastro de pessoas Físicas e Pessoas Jurídicas  |
|                                                   |
=====================================================
");

Utils.BarraDeCarregamento("Iniciando", 500, 10);

List<PessoaFisica> listPf = new List<PessoaFisica>();

string? opcao;

do
{
    
    Console.WriteLine(@$"
============================================
|    **Escolha uma das opções abaixo**     |
|------------------------------------------|
|        1- Pessoa Física                  |
|        2- Pessoa Jurídica                |
|        0 - Sair                          |
|===========================================
                      
");


opcao = Console.ReadLine();


switch (opcao)
{
    case "1":

        string? opcaoPf;

        do
        {
            

                Console.WriteLine(@$"
============================================
|    **Escolha uma das opções abaixo**     |
|------------------------------------------|
|        1- Cadastrar Pessoa Física        |
|        2- Listar Pessoa Física           |
|        0 - Voltar para o menu anterior   |
|===========================================
                      
");
            opcaoPf = Console.WriteLine();

            PessoaFisica metodosPf = new PessoaFisica();

            switch(opcaoPf)
            {
                case "1";
                    
                PessoaFisica novaPf = new PessoaFisica();
                Endereco endPf = new Endereco();
                


               // novaPf.Nome = "Carlos Drumond de Andrade";
                Console.WriteLine($"Digite o nome: ");
                novaPf.Nome = Console.ReadLine();

               // novaPf.Cpf = "13869584688";
                 Console.WriteLine($"Digite o CPF: ");
                novaPf.Cpf = Console.ReadLine();

                //novaPf.DataNascimento = new DateTime(2013, 10, 31);

                bool dataValida;

                do
                {
                    Console.WriteLine($"Digite a data de nasciemento:  Ex: DD/MM/AAAA: ");
                    string dataNasc = Console.ReadLine();

                    dataValida = metodosPf.ValidarDataNascimento(dataNasc);

                    if (dataValida)
                    {
                        DateTime dataConvertida;
                        DateTime.TryParse(dataNasc, out dataConvertida);
                        novaPf.DataNascimento = dataConvertida;

                        
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Data inválida! Digite uma data válida");
                        Console.ResetColor();
                    }

                } while (dataValida == false);
                  
                 //  novaPf.Rendimento = 25004.54f;
                 Console.WriteLine($"Digite o rendimento: ");
                 novaPf.Rendimento = float.Parse(Console.ReadLine());

               // endPf.Logradouro = "Avenida dos Poetas";
                Console.WriteLine($"Digite o Logradouro: ");
                endPf.logradouro = Console.ReadLine();

                //endPf.Numero = 100;
                 Console.WriteLine($"Digite o número: ");
                endPf.Numero = Int.Parse(Console.ReadLine());
                

                // endPf.Complemento = "casa";
                 Console.WriteLine($"Digite o complemento da casa: ");
                  endPf.Complemento = Console.ReadLine();
                
                // endPf.Comercial = false;
                Console.WriteLine($" Este endereço é comercial? Digite S para sim: ");
                string edCom = Console.ReadLine().Toupper();

                if(endCom == "S")
                {
                    endPf.Comercial = true;
                }
                else
                {
                    endPf.Comercial = false;
                }

                novaPf.Endereco = endPf;

                
                    listPf.Add(novaPf);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Cadastro realizado com sucesso!");
                    Thread.sleep(3000);
                    Console.ResetColor();

                    break;

                case "2";

                    if (listaPf.Count > 0 )
                    {
                        foreach (PessoaFisica cadaPessoa in listPf)
                        {
                            Console.clear();

                            Console.WriteLine(@$"

                            Nome: {CadaPessoa.Nome}
                            Cpf: {CadaPessoa.Cpf}
                            Data de nascimento: {CadaPessoa.DataNascimento}
                            Maior de idade: {(metodosPf.ValidarDataNascimento(CadaPessoa.DataNascimento) ? "Sim, maior de idade" : "Não, é menor de idade")}
                            Maior de idade(string): {(metodosPf.ValidarDataNascimento("05/12/2020") ?  "Sim, maior de idade" : "Não, é menor de idade")}
                            Rendimento: {CadaPessoa.Rendimento}
                            Imposto a pagar: {metodosPf.PagarImposto(CadaPessoa.Rendimento).ToString("c", new CultureInfo("pt-BR"))}
                            Endereço: {CadaPessoa.Endereco.Logradouro}, {CadaPessoa.Endereco.Numero}, {CadaPessoa.Endereco.Complemento}, {CadaPessoa.Endereco.Comercial}
                            ");
                        }
                        Console.WriteLine($"DIGITE 'ENTER' para continuar... ");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Lista vazia!");
                        Thread.Sleep(3000)
                        Console.ResetColor();
                    }
                    break;
                case "0";
                    break;
                default:

                Console.Clear();
                Console.WriteLine($"Opção inválida, por favor digite outra opção");
                Thread.Sleep(2000);
                Console.ResetColor();
            }

        } while (opcaoPf != 0);       

            Console.WriteLiner($"Aperte a tecla Enter para continuar");
            Console.ReadLine();
        break;
    
    case "2":

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

            Razão social: {novaPj.RazaoSocial}
            Cnpj: {novaPj.Cnpj}
            cnpj válido: {(metodosPj.ValidarCnpj(novaPj.cnpj) ? "cnpj válido!" : "cnpj inválido")}
            Redimento: {novaPj.Rendimento}
            Imposto a pagar: {metodosPj.PagarImposto(novaPj.Rendimento).ToString("c", new CultureInfo("pt-BR))}
            Endereço: {novaPJ.Endereco.Logradouro}, {novaPj.Endereco.Numero}, {novaPj.Endereco.Complemento}. {novaPj.Endereco.Comercial}
            ");
            Console.WriteLiner($"Aperte a tecla Enter para continuar");
            Console.ReadLine();
        break;

    case "0":   
        Console.Clear();
        Console.ForegroundColor = COnsole.Blue;
        Console.WriteLine($"Obrigado por utilizar o nosso sistema!");
        Thread.sleep(3000);
        break;
    Default:
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Opção inválida, escolha uma opção válida!");
        Console.ResetColor();
        Thread.sleep(3000);  
        Break;
    }

    
}while (opcao != "0");
    
 
Utils.BarraDeCarregamento("Finalizando", 3000,10);




//Instaciar o objeto PessoaJuridica


//Exemplo de expressão regular(Regex) para validar um formato de data
// Validação de um formato de data: "DD/MM/AAAA"
//string data = "01/11/2022";
//bool valido = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");

//Console.WriteLine(valido);

//Exemplo de substring
//string texto = "Ferrari";
//string substring = texto.substring(0, 4);
//Console.WriteLine(substring);





