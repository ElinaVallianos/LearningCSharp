namespace HomeWork13;

[Flags]
enum Survey
{
    bad = 0,
    tasety = 1,
    goodServes = 2,
    cheap = 4
}

enum Stars
{
    Zero,
    One,
    Two,
    Three
}

class Program
{
    static void Main(string[] args)
    {
        Survey survey;
        survey = new Survey();
        string answer;
        string[] questions = new string[] { "Was it tasety?", "Good Serves?", "Was it cheap?"};
        for (int i = 0; i < questions.Length ; i++)
        {
            Console.WriteLine(questions[i]);
            answer = Console.ReadLine().ToLower();

            switch (i)
            {
                case 0:
                    if (answer == "yes")
                    {
                        survey |= Survey.tasety;
                    }
                    break;
                case 1:
                    if (answer == "yes")
                    {
                        survey |= Survey.goodServes;
                    }
                    break;
                default:
                    if (answer == "yes")
                    {
                        survey |=  Survey.cheap;
                    }
                    break;
            }
        }

        Console.WriteLine(survey);
        SetStars(survey);
        Console.WriteLine("Stars: " + (int)SetStars(survey));
    }

    static Stars SetStars(Survey testResult)
    {
        int count = 0;
        Survey[] choices = new Survey[] { Survey.tasety, Survey.goodServes, Survey.cheap };
        foreach (var item in choices )
        {
            if (testResult.HasFlag(item)) //////
            {
                count++;
            }
        }

        switch (count)
        {
            case 0:
                return Stars.Zero;
            case 1:
                return Stars.One;
            case 2:
                return Stars.Two;
            default:
                return Stars.Three;
        }
    }
}

