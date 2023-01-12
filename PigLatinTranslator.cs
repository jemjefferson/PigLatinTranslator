namespace _10._3_Lab_Jefferson
{
    internal static class PigLatinTranslator
    {
        public static string ConvertToPigLatin(string[] sentence)
        {
            string[] result = new string[sentence.Length];
            for (int i = 0; i < sentence.Length; i++)
            {
                string currentWord = PigLatinHelper(sentence[i]);
                result[i] = currentWord;
            }

            string newSentence = "";
            for (int j = 0; j < result.Length; j++)
            {
                newSentence += result[j] + " ";
            }
            return newSentence;
        }

        private static string PigLatinHelper(string word)
        {
            string newWord = "";
            string[] consonant = new string[]{"sm","sn","st","sw","sk","sl","sp","sf","sc","bl","cl","cr","ck","ch","dr","fr","gl","gr","pl","pr","tr",
            "th","tw","wh","wr","br","fl","gh","qu","ph","ng"};
            string vowel = word[0].ToString().ToUpper();
            char[] wordArray = word.ToCharArray();

            if (vowel.Equals("A") || vowel.Equals("E") || vowel.Equals("I") || vowel.Equals("O") || vowel.Equals("U"))
            {
                word = word + "way";
                return word;
            }
            else if (word.Substring(0,2) != null && consonant.Contains(word.Substring(0,2)))
            {
                string twoCluster = word.Substring(0, 2);
                for (int i = 0; i < word.Length; i++)
                {
                    int index = i;
                    if (index > 1)
                    {
                        wordArray[i - 1] = word[index];
                        newWord += wordArray[i];
                    }
                }

                return newWord + twoCluster + "ay";
            }
            else
            {
                string firstLetter = word[0].ToString();

                for (int i = 0; i < word.Length; i++)
                {
                    int index = i;
                    if (index != 0)
                    {
                        wordArray[i - 1] = word[index];
                        newWord += wordArray[i];
                    }
                }
                return newWord + firstLetter + "ay";
            }
        }
    }
}
