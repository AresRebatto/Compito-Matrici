//Variabili
int rigaColonna;

//Input
do
{
    Console.Write("Inserire il numero di righe-colonne: ");
    rigaColonna = Convert.ToInt32(Console.ReadLine());


    if(rigaColonna > 3)
    {
        Console.WriteLine("Valore non valido. Puoi inserire al massimo una matrice 3x3.");
    }
}while(rigaColonna > 3);


int[,] matrice = new int[rigaColonna, rigaColonna];

//Popolazione della matrice
for(int i = 0; i < rigaColonna; i++)
{
    for(int n = 0; n < rigaColonna; n++)
    {
        Console.Write($"Inserire il valore della {i+1}a riga e della {n+1}a colonna: ");
        matrice[i,n] = Convert.ToInt32(Console.ReadLine());
    }
}

//Richiamo dei metodi
StampaMatrice(matrice);
Console.WriteLine("\n");
MatriceTrasposta(matrice);
Console.WriteLine("\n");
Console.WriteLine($"Il valore del determinante della matrice è {Determinante(matrice)}");

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

static int Determinante(int[,] matrice)
{
    if(matrice.GetLength(0) == 3)
    {
        return matrice[0,0]*matrice[1,1]*matrice[2,2]+matrice[0,1]*matrice[1,1]*matrice[0,2]+matrice[0,2]*matrice[1,0]*matrice[2,1]-matrice[0,0]*matrice[1,2]*matrice[2,0]-matrice[0,1]*matrice[1,0]*matrice[2,2]-matrice[2,0]*matrice[1,1]*matrice[2,0];
    }else
    {
        return matrice[0,0]*matrice[1,1]-matrice[0,1]*matrice[1,0];
    }
    
}