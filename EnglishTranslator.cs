namespace _10._3_Lab_Jefferson
{
    internal static class EnglishTranslator
    {
        public static string ConvertToEnglish(string[] sentence)
        {
                string[] result = new string[sentence.Length];
                for (int i = 0; i < sentence.Length; i++)
                {
                    string currentWord = EnglishHelper(sentence[i]);
                    result[i] = currentWord;
                }

                string newSentence = "";
                for (int j = 0; j < result.Length; j++)
                {
                    newSentence += result[j] + " ";
                }
                return newSentence;
        }

        private static string EnglishHelper(string word)
        {
            string newWord = "";

            if (word.Length > 3 && word.Substring(word.Length - 3) == "way")
            {
                newWord = word.Remove(word.Length - 3);

            }
            else if (word.Length > 2 && word.Substring(word.Length - 2) == "ay")
            {
                string firstLetter = word[word.Length - 3].ToString();
                string partialWord = word.Remove(word.Length - 3);
                char[] wordArray = partialWord.ToCharArray();

                for (int i = 0; i < wordArray.Length; i++)
                {
                    newWord += wordArray[i].ToString();
                }

                newWord = firstLetter + newWord;
            }
            else
            {
                newWord = word;
            }

            return newWord;
        }
    }
}
