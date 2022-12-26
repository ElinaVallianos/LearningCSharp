using System;

namespace HomeWork11;
class Program
{
    static void Main(string[] args)
    {
        
        string input = "What, exactly is Good and Bad? We say things are good and bad but how do we decide this?\n" +
            "Bad is defined as the opposite of good, so this means something assessed as such is unfit or morally reprehensible.\n" +
            "when something is moral, we say an act is good or bad. We also may say that the person is good or bad, although this implies that a person who does one bad thing has permanently bad intent and will always do bad things, and vice versa.\n" +
            "This makes good and bad uniquely human. Animals do not have morals, so predatory and possibly cruel (in our view) acts are neither good nor bad. We cannot say, for example, that a lion which kills a terrified buffalo is bad (or good).\n" +
            "Deciding whether something is good or bad is an evaluation, a decision. the concept of good and bad is important in our decision-making and we use our notions of goodness to censor both our own choices and those of others.\n" +
            "good and bad are defined by people. When nobody knows and there is nobody there to judge, then good and bad do not inherently exist.\n" +
            "Some who wear the goodguy badge are also actually good people.";

        Statistics(input);

        Console.WriteLine("Количество слов \"bad\" : " + NumberOfBad(input));

        Console.WriteLine();
        Console.WriteLine(Censor(input));


    }

    static void Statistics(string string1)
    {
        Console.WriteLine($"Количество символов: " + string1.Length);
        Console.WriteLine($"Количество букв: " + String.Join("",
            string1.Split(',', '.', ':', '(', ')', ' ' , '?', '!')).Remove('\n', 1).Length);


        int numberOf_Z = 1;
        int startIndex = 0;
        while (string1.IndexOf("\n", startIndex) > 0)
        {
            startIndex = string1.IndexOf("\n", startIndex);
            startIndex++;
            numberOf_Z++;
        }

        string1 = String.Join("", string1.Split('\n'));
        string[] splitSentanses = string1.Trim(' ', '.' , '?' ,'!').Split('.' , '?'); //разбивает на предложения
        Console.WriteLine($"Количество предложений: " + splitSentanses.Length );
        
        string[][] sentanses = new string[splitSentanses.Length][]; //предложения разбивает на слова
        for (int i = 0; i < splitSentanses.Length; i++)
        {
            sentanses[i] = splitSentanses[i].Trim().Split();
        }

        int numberOfWords = sentanses[0].Length;
        for (int i = 1; i < sentanses.Length ; i++)
        {
            numberOfWords += sentanses[i].Length;
        }
        Console.WriteLine($"Количество слов: " + numberOfWords );

        Console.WriteLine($"Количество абзацев: " + numberOf_Z);
        Console.WriteLine();
    }



    static int NumberOfBad(string string1)
    {
        int numberOfBed = 0;
        int startIndex = 0;
        while (string1.ToLower().IndexOf("bad",startIndex) > 0)
        {
            startIndex = string1.ToLower().IndexOf("bad", startIndex) + 1;
            numberOfBed++;
        }
        return numberOfBed;
    }



    static string Censor( string str)
    {

        string[] splitParagraph = str.Trim().Split('\n'); //разделяет на абзацы 
        for (int i = 0; i < splitParagraph.Length  ; i++)
        {
            //заглавная буква абзаца
            string firstLetter = splitParagraph[i].Trim().Substring(0, 1);
            firstLetter = firstLetter.ToUpper();
            splitParagraph[i] = firstLetter + splitParagraph[i].Trim().Remove(0, 1);

            string[] splitWords = splitParagraph[i].Trim().Split(); //разделяет на слова
            for (int j = 0; j < splitWords.Length ; j++)
            {
                string word = splitWords[j].Trim(' ', '.', ',', '(', ')', '?');
                string capitalLetter = word.Substring(0, 1); //заглавная буква слова
                if (i > 0)
                {
                    if (splitWords[i-1].EndsWith('.') || splitWords[i - 1].EndsWith('?'))
                    {
                        splitWords[j] = capitalLetter.ToUpper() + splitWords[j].Trim().Remove(0, 1);
                    }
                }

                switch (word)
                {
                    case "good":
                        splitWords[j] = splitWords[j].Replace("good", "bad");
                        break;
                    case "Good":
                        splitWords[j] = splitWords[j].Replace("Good", "Bad");
                        break;
                    case "bad":
                        splitWords[j] = splitWords[j].Replace("bad", "good");
                        break;
                    case "Bad":
                        splitWords[j] = splitWords[j].Replace("Bad", "Good");
                        break;
                    default:
                        break;
                }
            }
            splitParagraph[i] = String.Join(" ", splitWords);
        }

        string resultStr = "  " + String.Join("\n  ", splitParagraph);
        
        return resultStr;
    }
}
