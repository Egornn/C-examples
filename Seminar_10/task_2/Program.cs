//  В некотором машинном алфавите имеются четыре буквы «a», «i», «c» и «v». 
//Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.


void RecursiveNLetter (int wordLength, string [] alphabet, string currentWord = "")
{
    if (wordLength==0) 
    {
        System.Console.Write($"{currentWord}, ");
    }
    else
    {
        {
            foreach (string letter in alphabet)
            {
                currentWord = currentWord + letter;
                RecursiveNLetter(wordLength - 1, alphabet,currentWord);
                currentWord = currentWord.Substring(0, currentWord.Length - 1);

            }
            

        }
    }
}

int Prompt (string console)
{
    System.Console.WriteLine(console);
    string numberStr = Console.ReadLine();
    return int.Parse(numberStr);
}

void Solve()
{
    string[] alphabet = new string[] { "a", "i", "c", "v" };
    int wordLength = Prompt("Insert the length of the word");
    RecursiveNLetter(wordLength, alphabet);

}



Solve();