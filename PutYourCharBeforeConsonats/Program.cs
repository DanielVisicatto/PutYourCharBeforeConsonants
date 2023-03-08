string originalPhrase = "", newPhrase = "";
//string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
//char userCharactere;

//UserInteraction();
originalPhrase = (Console.ReadLine());
CreateString(originalPhrase);
Console.WriteLine("Translating...\n\n\n");
Console.Write("Your phrase: {0}\n\n\n\n\n", newPhrase);

//void UserInteraction()
{
    // Console.WriteLine("1st put your phrase here: ");
    // originalPhrase = Console.ReadLine();
    // Console.WriteLine("Now, put the character you want to add");
    //userCharactere = (char)(Console.Read());
}
string CreateString(string original)
{
    char[] aux = new char[original.Length * 2];
    for (int i = 0, j = 0; i < original.Length; i++)
    {
        if ((original[i] != 'a') && (original[i] != 'e') && (original[i] != 'i') && (original[i] != 'o') && (original[i] != 'u') &&
            (original[i] != 'A') && (original[i] != 'E') && (original[i] != 'I') && (original[i] != 'O') && (original[i] != 'U'))
        {
            aux[j + 1] = original[i];
            aux[j] = '.';
            j += 2;
        }
        else
        {
            aux[j] = original[i];
            j++;
        }
    }
    for (int i = 0; i < aux.Length; i++)
    {
        newPhrase += aux[i];
    }
    return newPhrase;
}
