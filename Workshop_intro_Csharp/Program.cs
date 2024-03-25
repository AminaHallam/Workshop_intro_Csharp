// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Uppgift 1 

/*
Console.WriteLine("Ange pris exklusive moms:");
double prisExklusiveMoms = double.Parse(Console.ReadLine());

double moms = prisExklusiveMoms * 0.25; // Antag att momssatsen är 25%
double prisInklusiveMoms = prisExklusiveMoms + moms;

Console.WriteLine($"Pris inklusive moms blir: {prisInklusiveMoms} (varav moms {moms})");

*/


// Uppgift 2 

/*

Console.WriteLine("Ange pris inklusive moms:");
double prisInklusiveMoms = double.Parse(Console.ReadLine());

double momssats = 0.25; // Momssatsen är 25%
double momsbelopp = (prisInklusiveMoms / (1 + momssats)) * momssats;
double prisExklusiveMoms = prisInklusiveMoms - momsbelopp;

Console.WriteLine($"Pris exklusive moms är: {prisExklusiveMoms}");

*/


// Uppgift 3


// En konstant variabel är en variabel vars värde inte kan ändras efter att den har tilldelats en initialt värde.
// Det betyder att en gång tilldelad, kan värdet inte ändras under körningstiden.
// Konstanta variabler används ofta för att definiera värden som förväntas förbli oförändrade under programkörningen.

// I C# deklareras en konstant variabel med nyckelordet const, och värdet måste tilldelas vid deklarationen. 



// Uppgift 4 

/*

int x = 4;
int y = 2;


// a. Här ökar x först efter att dess värde har tilldelats till y. Så, x ökar till 5, men y får värdet 4.
y = x++;


// b. Här ökar x först och sedan används det nya värdet för att tilldela y. Så, x ökar till 6, och y får också värdet 6.
y = ++x;


// c. Här multipliceras y med x. y är 6 och x är 6, så y blir 36.
y *= x;


// d. Här ökar vi y med x+2. x är 6, så y ökar med 6+2, vilket är 8.
y += (x + 2);


// e. Här minskar vi x först, så x blir 5, och sedan lägger vi till detta nya värdet till y. Så y blir 8+5=13.
y += --x;



// f. Här lägger vi först till x till y, så y blir 13+5=18, men x ökar sedan med 1 efter att det har använts, så x är nu 6.
y += x++;



// g. Här negativt x är lika med negativt y. y är 18, så x blir -18.
x = -y; 

*/


// Uppgift 5 

/*

Console.WriteLine("Skriv in första talet:");
int tal1 = int.Parse(Console.ReadLine());

Console.WriteLine("Skriv in andra talet:");
int tal2 = int.Parse(Console.ReadLine());

Console.WriteLine("Skriv in tredje talet:");
int tal3 = int.Parse(Console.ReadLine());

int mellansta = HittaMellansta(tal1, tal2, tal3);

Console.WriteLine($"Det mellersta talet är {mellansta}");


static int HittaMellansta(int a, int b, int c)
{
    if ((a >= b && a <= c) || (a <= b && a >= c))
        return a;
    else if ((b >= a && b <= c) || (b <= a && b >= c))
        return b;
    else
        return c;
}

*/


// Uppgift 6 

/*

Random random = new Random();
bool spelaIgen = true;

Console.WriteLine("Välkommen till gissa-talet spelet!");
Console.WriteLine("Du ska gissa på ett tal mellan 1 och 100");

while (spelaIgen)
{
    int hemligtTal = random.Next(1, 101);
    int antalGissningar = 0;
    bool rättGissat = false;

    while (!rättGissat)
    {
        Console.Write("gissa> ");
        int gissning = int.Parse(Console.ReadLine());
        antalGissningar++;

        if (gissning == hemligtTal)
        {
            Console.WriteLine($"Rätt gissat! Du har gissat {antalGissningar} gånger.");
            rättGissat = true;
        }
        else if (gissning < hemligtTal)
        {
            Console.WriteLine("Du har gissat för lågt!");
        }
        else
        {
            Console.WriteLine("Du har gissat för högt!");
        }
    }

    Console.Write("Spela en gång till (j/n): ");
    char val = Console.ReadKey().KeyChar;
    Console.WriteLine();
    spelaIgen = (val == 'j' || val == 'J');
}

Console.WriteLine("Adjö!");

*/

// Uppgift 7 

/*

Console.WriteLine("Skriv in den sträng du vill leta i:");
string sträng = Console.ReadLine();

Console.WriteLine("Vilken bokstav vill du räkna:");
char bokstav = Console.ReadKey().KeyChar;
Console.WriteLine();

int förekomster = RäknaFörekomsterAvBokstav(sträng, bokstav);

Console.WriteLine($"Strängen innehåller {förekomster} st {bokstav}:n.");


static int RäknaFörekomsterAvBokstav(string sträng, char bokstav)
{
    int förekomster = 0;
    for (int i = 0; i < sträng.Length; i++)
    {
        if (sträng[i] == bokstav)
        {
            förekomster++;
        }
    }
    return förekomster;
}


*/


// Uppgift 8 

/*

Console.WriteLine("Mata in strängen:");
string sträng = Console.ReadLine();

int antalA = 0, antalE = 0, antalI = 0, antalO = 0, antalU = 0, antalY = 0;

foreach (char bokstav in sträng)
{
    switch (char.ToLower(bokstav))
    {
        case 'a':
            antalA++;
            break;
        case 'e':
            antalE++;
            break;
        case 'i':
            antalI++;
            break;
        case 'o':
            antalO++;
            break;
        case 'u':
            antalU++;
            break;
        case 'y':
            antalY++;
            break;
        default:
            break;
    }
}

Console.WriteLine($"I strängen finns:");
Console.WriteLine($"{antalA} st a:n");
Console.WriteLine($"{antalE} st e:n");
Console.WriteLine($"{antalI} st i:n");
Console.WriteLine($"{antalO} st o:n");
Console.WriteLine($"{antalU} st u:n");
Console.WriteLine($"{antalY} st y:n");



*/



// Uppgift 9 

/*

Console.WriteLine("Skriv in ett heltal för att kontrollera om det är ett primtal:");
int tal = int.Parse(Console.ReadLine());

bool ärPrimtal = ÄrPrimtal(tal);

if (ärPrimtal)
{
    Console.WriteLine($"{tal} är ett primtal.");
}
else
{
    Console.WriteLine($"{tal} är inte ett primtal.");
}



static bool ÄrPrimtal(int tal)
{
    if (tal <= 1)
    {
        return false;
    }

    for (int i = 2; i <= Math.Sqrt(tal); i++)
    {
        if (tal % i == 0)
        {
            return false;
        }
    }

    return true;
}


*/



// Uppgift 10 

/*

Console.Write("Hur många tal vill du mata in (max 30)? ");
int antalTal = int.Parse(Console.ReadLine());

if (antalTal > 30 || antalTal <= 0)
{
    Console.WriteLine("Felaktigt antal tal.");
    return;
}

int[] talArray = new int[antalTal];

Console.WriteLine("Mata in talen:");


for (int i = 0; i < antalTal; i++)
{
    Console.Write($"{i + 1}. tal: ");
    talArray[i] = int.Parse(Console.ReadLine());
}

int summa = 0;
int minsta = talArray[0];
int största = talArray[0];

foreach (int tal in talArray)
{
    summa += tal;
    if (tal < minsta)
    {
        minsta = tal;
    }
    if (tal > största)
    {
        största = tal;
    }
}

double medelvärde = (double)summa / antalTal;

Console.WriteLine($"Summa: {summa}");
Console.WriteLine($"Medelvärde: {medelvärde}");
Console.WriteLine($"Minsta värde: {minsta}");
Console.WriteLine($"Största värde: {största}");


*/



// Uppgift 11

/*

Console.Write("Hur många studenter ska betyget matas in för? ");
int antalStudenter = int.Parse(Console.ReadLine());


if (antalStudenter <= 0)
{
    Console.WriteLine("Felaktigt antal studenter.");
    return;

}


int[] betyg = new int[antalStudenter];


for (int i = 0; i < antalStudenter; i++) 
{

    Console.Write($"Ange betyget för student {i + 1}:");
    betyg[i] = int.Parse(Console.ReadLine());

}


double genomsnittligtBetyg = BeräknaGenomsnittligtBetyg(betyg);

Console.WriteLine($"Det genomsnittliga betyget för gruppen är: {genomsnittligtBetyg}");


static double BeräknaGenomsnittligtBetyg(int[] betyg)
{
    int summa = 0;
    foreach (int betygEnhet in betyg)
    { 
        summa += betygEnhet;
    
    }
    return (double)summa / betyg.Length;

}



*/



// Uppgift 12


/*

Console.Write("Ange en sträng: ");
string sträng = Console.ReadLine();

Console.WriteLine($"Antal tecken i strängen: {RäknaTecken(sträng)}");
Console.WriteLine($"Strängen i versaler: {TillVersaler(sträng)}");
Console.WriteLine($"Strängen i gemener: {TillGemener(sträng)}");

if (ÄrPalindrom(sträng))
{
    Console.WriteLine("Strängen är en palindrom.");
}
else
{
    Console.WriteLine("Strängen är inte en palindrom.");
}


static int RäknaTecken(string sträng)
{
    return sträng.Length;
}

static string TillVersaler(string sträng)
{
    return sträng.ToUpper();
}

static string TillGemener(string sträng)
{
    return sträng.ToLower();
}

static bool ÄrPalindrom(string sträng)
{
    int vänster = 0;
    int höger = sträng.Length - 1;

    while (vänster < höger)
    {
        if (sträng[vänster] != sträng[höger])
        {
            return false;
        }
        vänster++;
        höger--;
    }
    return true;
}

*/


// Test uppgift från W3schools 


Console.Write("Ange din ålder: ");
int myAge = int.Parse(Console.ReadLine());

int votingAge = 18;

if (myAge >= votingAge)
{
    Console.WriteLine("Old enough to vote!");
}
else
{
    Console.WriteLine("Not old enough to vote.");
}



 
