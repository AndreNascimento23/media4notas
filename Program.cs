Console.Clear();

double n1, n2, n3, n4, media;
string resultado;
Console.Write("Digite a Primeira Nota..: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a Segunda Nota...: ");
n2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a Terceira Nota..: ");
n3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a Quarta Nota..: ");
n4 = Convert.ToDouble(Console.ReadLine());

bool nTodas = n1 >= 0 && n1<= 10
           && n2 >= 0 && n2<= 10
           && n3 >= 0 && n3<= 10
           && n4 >= 0 && n4<= 10;

if (nTodas)
{
    media = (n1 + n2 + n3 + n4) / 4;

    if (media < 5)
    {
        resultado = "Reprovado";
    }
    else if (media > 6)
    {
        resultado = "Aprovado";
    }
    else 
    {
        resultado = "Recuperação";
    }
    
    Console.Write($"Sua nota foi {media:N} . Resultado {resultado} ");

}
else 
{
    Console.WriteLine("Digite entre 0 e 10");
}


Console.WriteLine("\nObrigado !!");
