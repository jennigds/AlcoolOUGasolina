double etanol, gasolina, porcentagem;
string sera;

Console.WriteLine("ETANOL ou GASOLINA.\n");

Console.Write("Digite o preço do etanol: ");
etanol = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o preço da gasolina: ");
gasolina = Convert.ToDouble(Console.ReadLine());

porcentagem = (etanol / gasolina) * 100;

if (porcentagem > 73)
{
    sera = "Gasolina";
}
else
{
    sera = "Etanol";
}

Console.WriteLine($"O preço do etanol corresponde a {porcentagem:N1}% do preço da gasolina.");
Console.WriteLine($"Sugiro que abasteça com {sera.ToUpper()}");