string originalPhrase;
string newPhrase = "";
string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
char userCharactere;

UserInteraction();
CreateString(originalPhrase, userCharactere);
Console.WriteLine("Translating...\n\n\n");
Console.Write("Your phrase: {0}\n\n\n\n\n", newPhrase);

string CreateString(string original, char charac)
{
    foreach (char c in original)
    {
        if (consonants.Contains(c))
            newPhrase += c + charac.ToString();
        else
            newPhrase += c.ToString();        
    }
    return newPhrase;
}   
void UserInteraction()
{
    Console.WriteLine("1st put your phrase here: ");
    originalPhrase = Console.ReadLine();
    Console.WriteLine("Now, put the character you want to add");
    userCharactere = (char)(Console.Read());
}