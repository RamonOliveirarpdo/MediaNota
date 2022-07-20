decimal nota1, nota2, nota3, nota4, media;

Console.WriteLine("Escreva 1 nota: ");
nota1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Escreva 2 nota: ");
nota2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Escreva 3 nota: ");
nota3 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Escreva 4 nota: ");
nota4 = Convert.ToDecimal(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine("Sua media é: " + media);
if (media > 7)
        { Console.WriteLine("Reprovado"); }
    else 
        { Console.WriteLine("Aprovado"); }



