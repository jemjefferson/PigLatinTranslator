namespace _10._3_Lab_Jefferson
{
    internal static class RO13Cypher
    {
        public static string ConvertToRO13(string[] sentence)
        {
            string[] result = new string[sentence.Length];
            for (int i = 0; i < sentence.Length; i++)
            {
                string currentWord = CypherHelper(sentence[i]);
                result[i] = currentWord;
            }

            string newSentence = "";
            for (int j = 0; j < result.Length; j++)
            {
                newSentence += result[j] + " ";
            }
            return newSentence;
        }
        private static string CypherHelper(string word)
        {
            Dictionary<string, string> rO13 = GenerateCypher();

            string newWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                newWord += rO13[word[i].ToString()];
            }

            return newWord;
        }

        private static Dictionary<string, string> GenerateCypher()
        {
            Dictionary<string, string> rO13 = new Dictionary<string, string>();
            rO13.Add("A", "N");
            rO13.Add("B", "O");
            rO13.Add("C", "P");
            rO13.Add("D", "Q");
            rO13.Add("E", "R");
            rO13.Add("F", "S");
            rO13.Add("G", "T");
            rO13.Add("H", "U");
            rO13.Add("I", "V");
            rO13.Add("J", "W");
            rO13.Add("K", "X");
            rO13.Add("L", "Y");
            rO13.Add("M", "Z");
            rO13.Add("N", "A");
            rO13.Add("O", "B");
            rO13.Add("P", "C");
            rO13.Add("Q", "D");
            rO13.Add("R", "E");
            rO13.Add("S", "F");
            rO13.Add("T", "G");
            rO13.Add("U", "H");
            rO13.Add("V", "I");
            rO13.Add("W", "J");
            rO13.Add("X", "K");
            rO13.Add("Y", "L");
            rO13.Add("Z", "M");
            rO13.Add("a", "n");
            rO13.Add("b", "o");
            rO13.Add("c", "p");
            rO13.Add("d", "q");
            rO13.Add("e", "r");
            rO13.Add("f", "s");
            rO13.Add("g", "t");
            rO13.Add("h", "u");
            rO13.Add("i", "v");
            rO13.Add("j", "w");
            rO13.Add("k", "x");
            rO13.Add("l", "y");
            rO13.Add("m", "z");
            rO13.Add("n", "a");
            rO13.Add("o", "b");
            rO13.Add("p", "c");
            rO13.Add("q", "d");
            rO13.Add("r", "e");
            rO13.Add("s", "f");
            rO13.Add("t", "g");
            rO13.Add("u", "h");
            rO13.Add("v", "i");
            rO13.Add("w", "j");
            rO13.Add("x", "k");
            rO13.Add("y", "l");
            rO13.Add("z", "m");

            return rO13;
        }
    }
}
