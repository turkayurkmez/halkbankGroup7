// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string word = "halkbank";
bool isEndWithBank = word.EndsWith("bank");
if (isEndWithBank)
{
    Console.WriteLine("Evet bank ile bitiyor");
}

Console.WriteLine(word.ToUpper());

int index = word.IndexOf('a', 2);
Console.WriteLine(index);
int searchIndex = 0;
string findingPositions = "";
while (word.IndexOf('a', searchIndex) != -1)
{
    int findingIndex = word.IndexOf('k', searchIndex);
    findingPositions += $"{findingIndex}. ";
    searchIndex = findingIndex + 1;
}

Console.WriteLine(findingPositions);