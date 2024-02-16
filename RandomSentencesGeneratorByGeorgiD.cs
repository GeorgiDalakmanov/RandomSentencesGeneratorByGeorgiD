using System.Xml;

namespace RandomSentencesGeneratorByGeorgiD
{
    internal class RandomSentencesGeneratorByGeorgiD
    {
        static void Main()
        {
            string[] names = { "Peter", "Michell", "Jane", "Steve" };
            string[] place = { "Sofia", "Plovdiv", "Varna", "Burgas" };
            string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
            string[] details = { "near the river", "at home", "in the park" };

            Console.WriteLine("Hello, this is your first random-generated sentence: ");
            while (true)
            {
                string randomName = GetRandonWord(names);
                string randonPlace = GetRandonWord(place);
                string randomVerb = GetRandonWord(verbs);
                string randonNoun = GetRandonWord(nouns);
                string randonAdVerbs = GetRandonWord(adverbs);
                string randonDetails = GetRandonWord(details);

                string who = $"{randomName} from {randonPlace}";
                string action = $"{randonAdVerbs} {randomVerb} {randonNoun}";
                string sentence = $"{who} {action} {randonDetails}";
                Console.WriteLine(sentence);


                Console.WriteLine("Click [Enter] to generate a new one.");

                Console.ReadLine();
            }
        }

        private static string GetRandonWord(string[] words)
        {
            Random random = new Random();
            int rendomIndex = random.Next(words.Length);
            string word = words[rendomIndex];
            return word;
        }

    
        
    }
}
