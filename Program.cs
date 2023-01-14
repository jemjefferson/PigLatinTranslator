using _10._3_Lab_Jefferson;

Console.Title = "Pig Latin / English Translator";
Console.WriteLine("Welcome to the PigLatin Translator!");

bool exit = false;

try
{
    while (!exit)
    {
        Console.WriteLine("Please type in a translator. (PIG LATIN | ENGLISH)");
        Console.Write("]");
        string input = Console.ReadLine();
        input = input.ToLower().Trim();

        switch (input)
        {
            case "pig latin":
                Console.WriteLine("Enter a word or a sentence you would like to be translated into Pig Latin.");
                Console.WriteLine();
                string eng = Console.ReadLine();
                string[] engSentence = eng.Split(" ");
                bool engChar = false;

                foreach (string s in engSentence)
                {
                    foreach(char c in s)
                    {
                        if (Char.IsLetter(c) == false)
                        {
                            engChar = true;
                            break;
                        }
                    }
                }
                if (engChar == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Pig Latin: " + PigLatinTranslator.ConvertToPigLatin(engSentence));
                    Console.WriteLine("RO13Cypher: " + RO13Cypher.ConvertToRO13(engSentence));
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Please do not enter any special characters or punctuation \n");
                }
                break;
            case "english":
                Console.WriteLine("Enter a word or a sentence in Pig Latin that you would like to be translated into English.");
                string pig = Console.ReadLine();
                string[] pigSentence = pig.Split(" ");

                bool pigChar = false;

                foreach (string s in pigSentence)
                {
                    foreach (char c in s)
                    {
                        if (Char.IsLetter(c) == false)
                        {
                            pigChar = true;
                            break;
                        }
                    }
                }
                
                if (pigChar == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("English: " + EnglishTranslator.ConvertToEnglish(pigSentence));
                    Console.WriteLine("RO13 Cypher: " + RO13Cypher.ConvertToRO13(pigSentence));
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Please do not enter any special characters or punctuation \n");
                }
                break;
            case "exit":
                exit = true;
                break;
            default:
                Console.WriteLine("Enter either Pig Latin or English");
                Console.WriteLine("");
                break;
        }

    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}



