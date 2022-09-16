////Snack1.
////L'utente inserisce due numeri in successione. Il software stampa il maggiore.

//Console.WriteLine("Inserisci il primo numero");

//int firstNumber = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Inserisci il secondo numero");

//int secondNumber = Convert.ToInt32(Console.ReadLine());

//if (firstNumber > secondNumber)
//{
//    Console.WriteLine($"Il numero maggiore é {firstNumber}");
//}
//else
//{
//    Console.WriteLine($"Il numero maggiore é {secondNumber}");
//}
//// v2
//int maxNum = firstNumber > secondNumber ? firstNumber : secondNumber;
//Console.WriteLine(maxNum);


////Snack2.
////L'utente inserisce due parole in successione. Il software stampa prima la parola piú corta, poi la piú lunga.

//Console.WriteLine("Inserisci la prima parola");

//string firstWord = Console.ReadLine();

//Console.WriteLine("Inserisci la seconda parola");

//string secondWord = Console.ReadLine();

//if (firstWord.Length > secondWord.Length)
//{
//    Console.WriteLine($"La parola piú corta é {secondWord}");
//    Console.WriteLine($"La parola piú lunga é {firstWord}");
//}
//else if (firstWord.Length < secondWord.Length)
//{
//    Console.WriteLine($"La parola piú corta é {firstWord}");
//    Console.WriteLine($"La parola piú lunga é {secondWord}");
//}
//else
//{
//    Console.WriteLine("Le parole hanno lunghezza uguale");
//}


////Snack3.
////Il software deve chiedere per 10 volte all'utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.

//int sum = 0;

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"Inserisci un numero (.{i + 1})");
//    sum += Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine($"La somma dei tuoi numeri é {sum}");


////Snack4.
////Calcola la somma e la media dei numeri da 2 a 10.

//Console.WriteLine("Calcolo la somma e la media dei numeri da 2 a 10");

//int[] arrayOfNumbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//int sum2 = 0;

//for (int i = 0; i < arrayOfNumbers.Length; i++)
//{
//    sum2 += arrayOfNumbers[i];
//}
//Console.WriteLine($"La somma dei numeri é {sum2}");
//Console.WriteLine($"La media dei numeri é {sum2 / arrayOfNumbers.Length}");


////Snack5.
////Il software chiede all'utente di inserire un numero. Se il numero inserito e pari, stampa il numero, se dispari, stampa il numero successivo.

//Console.WriteLine("Inserisci un numero");

//int userNumber = Convert.ToInt32(Console.ReadLine());

//if (userNumber % 2 == 0)
//{
//    Console.WriteLine($"Hai inserito un numero pari: {userNumber}");
//}
//else
//{
//    Console.WriteLine($"Hai inserito un numero dispari({userNumber}). Il suo successivo é: {userNumber + 1}");
//}


////Snack6.
////In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all'utente il suo nome e comunicagli se puó partecipare o meno alla festa.

//string[] guestsList = { "mario", "francesco", "dario", "luca", "gigi", "maria", "anna" };

//Console.WriteLine("Il suo nome, prego...");

//string guestName = Console.ReadLine().ToLower();

//bool status = false;

//foreach (string guest in guestsList)
//{
//    if (guestName == guest)
//    {
//        status = true;
//        break;
//    }
//}

//if (status)
//{
//    Console.WriteLine("Prego, puó entrare.");
//}
//else
//{
//    Console.WriteLine("Mi discpiace, non é in lista.");
//}


//Snack7.
//Crea un array vuoto. Chiedi per 6 volte all'utente di inserire un numero, se é dispari inseriscilo nell'array.

int[] newArray = { };

for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Inserisci un numero");
    int userNum = Convert.ToInt32(Console.ReadLine());
    if (userNum % 2 != 0)
    {
        newArray.Append(userNum);
    }
}

Console.WriteLine(newArray.ToString());


//Snack8.
//Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

int[] intNumbersArray = { 1, 2, 5, 7, 12, 56, 21, 87, 55, 32 };

int oddSum = 0;

for (int i = 0; i < intNumbersArray.Length; i++)
{
    if (i % 2 != 0)
    {
        Console.Write($"{intNumbersArray[i]} ");
        oddSum += intNumbersArray[i];
    }
}
Console.WriteLine($"La somma degli elementi in posizione dispari é {oddSum}");


//Snack9.
//Crea un array vuoto e chiedi all'utente un numero da inserire nall'array. Continua a chiedere i numeri all'utente e ad inserirli nell'array fino a quando la somma degli elementi é minore di 50.

int[] infArray = new int[50];

int sum = 0;

int index2 = 0;

Console.WriteLine("Inserisci un numero");

int userNumber2 = Convert.ToInt32(Console.ReadLine());

while(sum < 50)
{

}

 


//Snack10.
//Fai inserire un numero, che chiameremo N, all'utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.

int N = Convert.ToInt32(Console.ReadLine());

int[] array;

for (int i = 0; i < N; i++)
{
    array = new int[10];

    for (int j = 0; j < N; j++)
    {
        array[j] = new Random().Next(1, 100);
    }

    for (int j = 0; j <= 10; j++)
    {
        Console.Write(array[j]);
    }
}

