public static class Questa3
{
    public static int SomaDaMediaComMaiorNumero(int[] array)
    {
        int soma = array.Sum();
        int media = soma / array.Length;

        int maiorValor = array.Max();


        return maiorValor + media;
    }

    // outra forma

    public static int SomaDaMediaComMaiorNumero2(int[] array)
    {
        int soma = 0;
        int maiorNumero = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            soma += array[i];
            if (maiorNumero < array[i])
            {
                maiorNumero = array[i];
            }

        }

        return soma / array.Length + maiorNumero;

    }

}