using targetSistemas;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número, n]ão deixe o campo vazio e também não digite letras.: ");
        string numeroString = Console.ReadLine();

        if (string.IsNullOrEmpty(numeroString))
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        int numero = int.Parse(numeroString);

        Fibonacci f = new Fibonacci(numero);
        f.ImprimirSequencia();
        f.VerificarPertinencia();

        Console.WriteLine("=====================================");
        Console.WriteLine("Agora vamos para a etapa de número 3...");
        Console.WriteLine("=====================================");
        Console.WriteLine(" ");

        Console.WriteLine("Que consiste no código de uma distribuidora, e que deve ser utilizado uma array para guardar os dados.");
        Console.WriteLine("");

        double[] faturamento = { 1200.0, 2700.0, 3000.0, 4000.0, 500.0, 0.0, 0.0, 0.0, 1000.0, 2000.0, 3000.0, 5000.1, 5000.0 };
        targetDistribuidora distribuidora = new targetDistribuidora(faturamento);
        Console.WriteLine("");
        Console.WriteLine("Menor faturamento diário: " + distribuidora.MenorFaturamento());
        Console.WriteLine("Maior faturamento diário: " + distribuidora.MaiorFaturamento());
        Console.WriteLine("Dias acima da média mensal: " + distribuidora.DiasAcimaDaMedia());

        Console.WriteLine("=====================================");
        Console.WriteLine("Agora vamos para a etapa de número 4...");
        Console.WriteLine("=====================================");
        Console.WriteLine(" ");

        FaturamentoDistribuidora fD = new FaturamentoDistribuidora
        {
            Sp = 67836.43,
            Rj = 36678.66,
            Mg = 29229.88,
            Es = 27165.48,
            Outros = 19849.53
        };

        var percentuais = fD.CalcularPercentuais();

        foreach (var estado in percentuais)
        {
            Console.WriteLine("{0}: {1:F2}%", estado.Key, estado.Value);
        }


        Console.WriteLine("=====================================");
        Console.WriteLine("Agora vamos para a etapa de número 5...");
        Console.WriteLine("=====================================");
        Console.WriteLine(" ");

        {
            Console.Write("Digite uma frase para ser escrita ao contrário!: ");
            string str = Console.ReadLine();

            char[] chars = str.ToCharArray();

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
            }

            string strInvertida = new string(chars);

            Console.WriteLine("Frase invertida: " + strInvertida);
        }


        Console.WriteLine(" ");
        Console.WriteLine("===FIM===");
        Console.WriteLine("Tecle Enter para fechar o Console. =D");
        Console.ReadKey();
    }
}
