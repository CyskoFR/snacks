//Snack1.
//L'utente inserisce due numeri in successione. Il software stampa il maggiore.

Console.WriteLine("Inserisci il primo numero");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserisci il secondo numero");

int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine($"Il numero maggiore é {firstNumber}");
}
else
{
    Console.WriteLine($"Il numero maggiore é {secondNumber}");
}


//Snack2.
//L'utente inserisce due parole in successione. Il software stampa prima la parola piú corta, poi la piú lunga.

Console.WriteLine("Inserisci la prima parola");

string firstWord = Console.ReadLine();

Console.WriteLine("Inserisci la seconda parola");

string secondWord = Console.ReadLine();

if (firstWord.Length > secondWord.Length)
{
    Console.WriteLine($"La parola piú lunga é {firstWord}");
}
else
{
    Console.WriteLine($"La parola piú lunga é {secondWord}");
}


//Snack3.
//Il software deve chiedere per 10 volte all'utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.

int sum = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Inserisci un numero (.{i + 1})");
    sum += Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"La somma dei tuoi numeri é {sum}");


//Snack4.
//Calcola la somma e la media dei numeri da 2 a 10.

Console.WriteLine("Calcolo la somma e la media dei numeri da 2 a 10");

int[] arrayOfNumbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10};

int sum2 = 0;

for (int i = 0; i < arrayOfNumbers.Length; i++)
{
    sum2 += arrayOfNumbers[i];
}
Console.WriteLine($"La somma dei numeri é {sum2}");
Console.WriteLine($"La media dei numeri é {sum2 / arrayOfNumbers.Length}");


//Snack5.
//Il software chiede all'utente di inserire un numero. Se il numero inserito e pari, stampa il numero, se dispari, stampa il numero successivo.

Console.WriteLine("Inserisci un numero");

int userNumber = Convert.ToInt32(Console.ReadLine());

if(userNumber % 2 == 0)
{
    Console.WriteLine($"Hai inserito un numero pari: {userNumber}");
}
else
{
    Console.WriteLine($"Hai inserito un numero dispari({userNumber}). Il suo successivo é: {userNumber+1}");
}