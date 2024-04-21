Console.Write("Digite o numerador: ");
double numerador = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o denominador: ");
double denominador = Convert.ToDouble(Console.ReadLine());

if (denominador == 0)
{
    Console.Write("Não é possível dividir por zero.");
}

else
{
    double quociente = numerador / denominador;
    Console.Write($"\n{numerador:N1} dividido por {denominador:N1} é {quociente:N1}.");
}