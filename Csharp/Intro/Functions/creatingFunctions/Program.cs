// See https://aka.ms/new-console-template for more information
//int number = 8;
//showMessage($"{number} sayısının karesi {getSquare(number)} eder", ConsoleColor.Green);
/*
 * 1. Kullanıcı oyundan çıkmadığı sürece oynamaya devam eder.
 * 2. 1-100 arasında rastgele bir sayı tut.
 * 3. Kullanıcıdan bu sayıyı tahmin etmesini iste
 * 4. Girilen sayı ile tutulan sayıyı  karşılaştır.
 *    4. a  Tahmin edilen, tutulandan büyükse, "Aşağı" diye yönlendirin.
 *       b                            küçükse, "Yukarı" 
 *       c                            eşitse, "Bildiniz"
 * 5. Eşit olmadığı sürece 3. Adıma geri döndür.
 * 6. Eğer bilindiyse tekrar oynamak isteyip istemediğini sor.
 */


do
{
    int target = getRandomNumber(1, 100);
    bool isGameOver = false;
    while (!isGameOver)
    {
        int suggest = getSuggestFromUser();
        bool isEqual = compare(target, suggest);
        isGameOver = isEqual;
    }

    Console.WriteLine("Tekrar oynamak ister misiniz (E/H)?");

} while (Console.ReadLine() != "E");



int getRandomNumber(int min, int max)
{
    Random randomGenerator = new Random();
    int randomNumber = randomGenerator.Next(min, max);
    return randomNumber;
}

int getSuggestFromUser()
{
    Console.WriteLine("Sayıyı tahmin edin:");
    int number = 0;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Lütfen sayı giriniz...");
    }
    return number;
}

bool compare(int target, int suggest)
{
    bool result = false;
    if (suggest > target)
    {
        Console.WriteLine("Aşağı");
    }
    else if (suggest < target)
    {
        Console.WriteLine("Yukarı");
    }
    else
    {
        Console.WriteLine("Bildiniz!");
        result = true;
    }
    return result;
}





int getLetterCountInWord(string word)
{
    return word.Length;
}

int getSquare(int value)
{
    return value * value;
}

void showMessage(string message, ConsoleColor consoleColor)
{
    Console.ForegroundColor = consoleColor;
    Console.WriteLine(message);
}

