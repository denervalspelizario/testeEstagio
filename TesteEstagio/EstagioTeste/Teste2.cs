namespace EstagioTeste
{
    public static class Teste2
    {
        public static void ContemLetraA(string dadoEntrada)
        {
            
            string valorRecebido = dadoEntrada;
           
            char[] arrayChar = valorRecebido.ToCharArray();

            if (arrayChar.Contains('a') == true || arrayChar.Contains('A') == true)
            {
                Console.WriteLine($"O {valorRecebido} contem a letra a/A");   
            }
            else
            {
                Console.WriteLine($"O {valorRecebido} não contem a letra a/A");
            }
        }
    }
}
