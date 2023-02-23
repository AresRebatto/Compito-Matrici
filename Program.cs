//Variabili
int riga;
int colonna;

//Input
Console.Write("Inserire il numero di righe: ");
riga = Convert.ToInt32(Console.ReadLine());

Console.Write("Inserire il numero di colonne: ");
colonna = Convert.ToInt32(Console.ReadLine());

int[,] matrice = new int[riga, colonna];

//Popolazione della matrice
for(int i = 0; i < riga; i++)
{
    for(int n = 0; n < riga; n++)
    {
        Console.Write($"Inserire il valore della {i+1}a riga e della {n+1}a colonna: ");
        matrice[i,n] = Convert.ToInt32(Console.ReadLine());
    }
}

//Richiamo dei metodi
StampaMatrice(matrice);
Console.WriteLine("\n");
MatriceTrasposta(matrice);


//Metodi
static void MatriceTrasposta(int[,] matrice)
{
    int n = matrice.GetLength(0);
    int[,] matriceTrasposta = new int[n,n];
    for(int i = 0; i < n; i++)
    {
        for(int m = 0; m < n; m++)
        {
            matriceTrasposta[i,m] = matrice[m,i];
        }
    }
    StampaMatrice(matriceTrasposta);
}

static void StampaMatrice(int[,] matrice)
{
    int n = matrice.GetLength(0);
    for(int i = 0; i < n; i++)
    {
        for(int m = 0; m < n; m++)
        {
            Console.Write($"{matrice[i,m]}\t");
        }
        Console.Write("\n");
    }
}