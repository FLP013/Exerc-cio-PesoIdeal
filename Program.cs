double Altura, PesoIdeal;
string Sexo;

Console.Clear();

Console.WriteLine("--- PESO IDEAL ---");
Console.Write("Me diga á sua altura: ");
Altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Me diga o seu sexo: ");
Sexo = (Console.ReadLine()!).ToUpper();

if (Sexo == "M")
{
PesoIdeal = Altura * 72.7 - 58.0;
}
else 
{
    PesoIdeal = Altura * 62.1 - 44.7;
}

Console.WriteLine($"Seu peso ideal é de {PesoIdeal:N1}kg.");