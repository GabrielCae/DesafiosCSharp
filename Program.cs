using Utils;

bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine("=== MENU DE DESAFIOS C# ===");
    Console.WriteLine("1 - Boas Vindas");
    Console.WriteLine("2 - Boas Vindas com Sobrenome");
    Console.WriteLine("3 - Operações Matemáticas");
    Console.WriteLine("4 - Contador de Caracteres");
    Console.WriteLine("5 - Verificar Placa (Antiga)");
    Console.WriteLine("6 - Verificar Placa (Mercosul)");
    Console.WriteLine("7 - Exibir Datas");
    Console.WriteLine("0 - Sair");
    Console.Write("\nEscolha uma opção: ");

    string opcao = Console.ReadLine() ?? "";

    Console.WriteLine();

    switch (opcao)
    {
        case "1": AuxiliarFunctions.BoasVindas(); break;
        case "2": AuxiliarFunctions.BoasVindasComSobrenome(); break;
        case "3": AuxiliarFunctions.OperacoesMatematicas(); break;
        case "4": AuxiliarFunctions.ContadorDeCaracteres(); break;
        case "5": AuxiliarFunctions.VerificaPlaca(); break;
        case "6": AuxiliarFunctions.VerificaPlacaMercosul(); break;
        case "7": AuxiliarFunctions.DataAtual(); break;
        case "0": continuar = false; break;
        default: Console.WriteLine("Opção inválida!"); break;
    }

    if (continuar)
    {
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
}