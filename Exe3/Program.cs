using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "Jean";
p1.Idade = 25;

p1.EnderecoPessoa = new Endereco()
{
  Logradouro = "Rua Chaves Eldorado",
  Numero = 221,
  CEP = "45698",
  Cidade = "São Paulo",
};

WriteLine("Fim");