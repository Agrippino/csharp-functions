//creo arrey numeri interi e lo stampo
Console.WriteLine("inserisci il numero di elementi");
int  numeroElementi = int.Parse(Console.ReadLine());
int[] array2 = new int[numeroElementi];
StampaArray(array2);

//stampo i risultati delle funzioni create

StampaArray(ElevaArrayAlQuadrato(array2));
int sommaDegliArray = sommaElementiArray(array2);
int sommaArrayAlQuadrato = sommaElementiArray(ElevaArrayAlQuadrato(array2));
Console.WriteLine(sommaDegliArray);
Console.WriteLine(sommaArrayAlQuadrato);

for (int i= 0; i < array2.Length; i++)
{
    int elementoInserito= int.Parse(Console.ReadLine());
    array2[i] = elementoInserito;
}




void StampaArray(int[] array)
{
    int ultimoIndiceArray = array.Length - 1;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == ultimoIndiceArray)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}

//creo la funzione quadrato di un numero
int Quadrato(int numero)
{
    int riusultatoQuadrato = numero * numero;
    return riusultatoQuadrato;
}

//creo una funzione che eleva tutti i numeri al quadrato


int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayClonato = (int[])array.Clone();
    for (int i = 0; i < array.Length; i++)
    {
        arrayClonato[i] = Quadrato(arrayClonato[i]);

    }
    return arrayClonato;
}

//
int sommaElementiArray(int[] array)
{
    int[] arrayClonato = (int[])array.Clone();
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {

        somma = somma + arrayClonato[i];

    }
    return somma;
}
