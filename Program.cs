using ExemploExplorando.Models;
using System.Globalization;
using Models;
using Newtonsoft.Json;


// Os códigos estão comentados por seções inicio/fim exemplo conforme as aulas.
// Basta descomentar as seções e executar individualmente

// INICIO EXEMPLO -------------------------------------------------------
// int a = 10;

// int b = a;
// b = 60;

// Console.WriteLine($"Valor de A: {a}");
// Console.WriteLine($"Valor de B: {b}");

// Pessoa p1 = new Pessoa();
// Pessoa p2 = p1;

// FIM EXEMPLO -------------------------------------------------------

// INICIO EXEMPLO -------------------------------------------------------

// Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");

// Pessoa p2 = p1;
// p2.Nome = "Vinicius";


// Console.WriteLine($"Nome da pessoa p1: {p1.NomeCompleto}");
// Console.WriteLine($"Nome da pessoa p2: {p2.NomeCompleto}");

// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// int numero = 15;
// bool par = false;

// // IF Ternário
// par = numero.EhPar();

// string mensagem = "O número " + numero + " " + "é " + (par ? "par" : "ímpar");
// Console.WriteLine(mensagem);

// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// MeuArray<int> arrayInteiro = new MeuArray<int>();

// for (int i = 0; i < 11; i++)
// {
//     arrayInteiro.AdicionarElementoArray(i);
// }

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(arrayInteiro[i]);
// }


// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach(var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }

// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// var tipoAnonimo = new { Nome = "Leonardo", Sobrenome = "Buta", Altura = 1.80 };

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);

// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
//                       $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" +
//                       $" {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
// }

// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
//                       $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
// }


// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);

// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// int numero = 20;
// bool par = false;

// // IF Ternário
// par = numero % 2 == 0;

// string mensagem = "O número " + numero + " " + "é " + (par ? "par" : "ímpar");
// Console.WriteLine(mensagem);


// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar");
// }

// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// Pessoa p1 = new Pessoa("Leonardo", "Buta");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");

// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     //Console.WriteLine("Quantidade linhas do arquivo:" + quantidadeLinhas);
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }


// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Leonardo", "Buta", 1.80M);

// //ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Leonardo", "Buta", 1.80M);
// //var outroExemploTuplaCreate = Tuple.Create(1, "Leonardo", "Buta", 1.80M);


// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");


// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");


// Console.WriteLine(estados["MG"]);

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("----------");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA2";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }


// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);
// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }


// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }


// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

//new ExemploExcecao().Metodo1();

// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

//string[] linhasExemplo = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");
//Console.WriteLine("Chegou até aqui");


// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/darquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine("Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. "
//      + ex.Message);
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }

// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// string dataString = "2022-04-170 18:00";

// bool sucesso = DateTime.TryParseExact(dataString,
//                       "yyyy-MM-dd HH:mm",
//                       CultureInfo.InvariantCulture,
//                       DateTimeStyles.None, out DateTime data);


// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
//}


// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// int numero1 = 10;
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);

// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();


// FIM EXEMPLO -------------------------------------------------------


// INICIO EXEMPLO -------------------------------------------------------

// Pessoa p1 = new Pessoa();
// p1.Nome = "Leonardo";
// p1.Sobrenome = "Buta";
// p1.Idade = 20;
// p1.Apresentar();

// FIM EXEMPLO -------------------------------------------------------