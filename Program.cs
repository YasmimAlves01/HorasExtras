double valorHora, horasTrabalhadas, horaExtra;


Console.WriteLine("Bem-vindo ao Calculo de Salario");

Console.WriteLine("Por favor informe o valor que você recebe por hora:");
valorHora = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Por favor agora informe quantas horas você trabalhou:");
horasTrabalhadas = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Por favor informe a quantidade de horas extras que você tem:");
horaExtra = Convert.ToDouble(Console.ReadLine()!);


double CalculaSalario(double valorHora, double horasTrabalhadas, double horaExtra)
{
    double totalSalario = horasTrabalhadas * valorHora;

    double totalHoraExtra = valorHora * (horaExtra * 1.4);

    return totalHoraExtra + totalSalario;

}


double salarioFinal = CalculaSalario(valorHora, horasTrabalhadas, horaExtra);
Console.WriteLine($"Seu salario total é: {salarioFinal:C2}");
