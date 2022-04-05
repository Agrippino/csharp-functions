//creo arrey numeri interi e lo stampo
int[] arrayDiNumeri= { 2, 6, 7, 5, 3, 9 };
StampaArray(arrayDiNumeri);
StampaArray(ElevaArrayAlQuadrato(arrayDiNumeri));
int sommaDegliArray= sommaElementiArray(arrayDiNumeri);
int sommaArrayAlQuadrato = sommaElementiArray(ElevaArrayAlQuadrato(arrayDiNumeri));
Console.WriteLine(sommaArrayAlQuadrato);
Console.WriteLine (sommaDegliArray);



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
        
    }return arrayClonato;
}

//
int sommaElementiArray(int[] array)
{
    int[] arrayClonato = (int[])array.Clone();
     int somma = 0;
   for (int i = 0; i < array.Length; i++)
    {
       
        somma = somma + arrayClonato[i];
        
    }return somma;
}