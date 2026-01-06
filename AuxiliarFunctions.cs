using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Utils;

public static class AuxiliarFunctions
{
    private static string Input(string text)
    {
        Console.Write($"{text}: ");
        string? entrada = Console.ReadLine();

        return entrada ?? "";
    }

    public static void BoasVindas()
    {
        string nome = Input("Insira seu nome");
        Console.WriteLine($"Bem vindo, {nome}!");
    }

    public static void BoasVindasComSobrenome()
    {
        string nome = Input("Insira seu nome");
        string sobrenome = Input("Insira seu sobrenome");

        Console.WriteLine($"Bem vindo, {nome} {sobrenome}!");
    }

    public static void OperacoesMatematicas()
    {
        double numero1 = double.Parse(Input("Insira o primeiro número"));
        double numero2 = double.Parse(Input("Insira o segundo número"));

        Console.WriteLine($"A soma entre os números é: {numero1 + numero2}");
        Console.WriteLine($"A subtração entre os números é: {numero1 - numero2}");
        Console.WriteLine($"A multiplicação entre os números é: {numero1 * numero2}");

        double divisao = numero2 != 0 ? numero1 / numero2 : 0;
        Console.WriteLine($"A divisão entre os números é: {divisao}");

        Console.WriteLine($"A média entre os números é: {(numero1 + numero2) / 2}");
    }

    public static void ContadorDeCaracteres()
    {
        string palavra = Input("Insira uma frase");

        Console.WriteLine($"A frase {palavra} possui {palavra.Length} caracteres");
    }

    public static bool VerificaPlaca()
    {
        string placa = Input("Insira a placa do veículo").Trim();

        if (placa.Length != 7)
        {
            Console.WriteLine("Falso");
            return false;
        }

        for (int i = 0; i < 7; i++)
        {
            char c = placa[i];

            if (i < 3)
            {
                if (!Char.IsLetter(c))
                {
                    Console.WriteLine("Falso");
                    return false;
                }
            } else
            {
                if (!Char.IsDigit(c))
                {
                    Console.WriteLine("Falso");
                    return false;
                }
            }
        }

        Console.WriteLine("Verdadeiro");
        return true;
    }

    public static bool VerificaPlacaMercosul() // bônus - com regex
    {
        string placa = Input("Insira a placa Mercosul").Trim();

        bool valida = Regex.IsMatch(placa, @"^[a-zA-Z]{3}\d[a-zA-Z]\d{2}$");

        Console.WriteLine(valida ? "Verdadeiro" : "Falso");
        return valida;
    }

    public static void DataAtual()
    {
        DateTime now = DateTime.Now;

        Console.WriteLine($"{now.ToString("dddd dd/MM/yyyy HH:mm:ss")}");
        Console.WriteLine($"{now.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"{now.ToString("HH:mm:ss")}");
        Console.WriteLine($"{now.ToString("dd MMMM yyyy")}");

    }
}
