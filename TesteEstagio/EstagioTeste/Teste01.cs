
namespace EstagioTeste
{
    public static class Teste01
    {
        public static void PertenceSequenciaFibonacci(string dadoEntrada)
        {
            int numeroEntrada = int.Parse(dadoEntrada);
            bool resposta = VerificaFibonacci(numeroEntrada);
            

            if (resposta == true)
            {
                string respostaFinal = $"O número {numeroEntrada} pertence à sequência de Fibonacci.";
                Console.WriteLine(respostaFinal);
                return ;
            }
            else
            {
                string respostaFinal = $"O número {numeroEntrada} não pertence à sequência de Fibonacci.";
                Console.WriteLine(respostaFinal);
                return ;
            }
        }



        public static bool VerificaFibonacci(int numeroEntrada)
        {
            if (numeroEntrada < 0)
            {
                return false;
            }

            int n1 = 0;
            int n2 = 1;

            while(n1 <= numeroEntrada)
            {
                if (n1 == numeroEntrada)
                {
                    return true;
                }
                int proximoNumero = n1 + n2;
                n1 = n2;
                n2 = proximoNumero;
            }
            return false;
        }
    }
}