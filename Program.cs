using _10._3_Lab_Jefferson;

Console.Title = "Pig Latin / English Translator";
Console.WriteLine("Please type in a translator. (PIG LATIN | ENGLISH)");

bool exit = false;

try
{
    while (!exit)
    {

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
                Console.WriteLine("");
                Console.WriteLine("Pig Latin: " + PigLatinTranslator.ConvertToPigLatin(engSentence));
                Console.WriteLine("RO13Cypher: " + RO13Cypher.ConvertToRO13(engSentence));
                Console.WriteLine("");
                break;
            case "english":
                Console.WriteLine("Enter a word or a sentence in Pig Latin that you would like to be translated into English");
                string pig = Console.ReadLine();
                string[] pigSentence = pig.Split(" ");
                Console.WriteLine("");
                Console.WriteLine("English: " + EnglishTranslator.ConvertToEnglish(pigSentence));
                Console.WriteLine("RO13 Cypher: " + RO13Cypher.ConvertToRO13(pigSentence));
                Console.WriteLine("");
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



