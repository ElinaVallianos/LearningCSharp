namespace HomeWork13;

[Flags]
enum Survey
{
    //yes = 1,
    //no = 0
    tasety = 2,
    discusting = 4,
    goodServes = 8,
    badServes = 16,
    cheap = 32,
    expensive = 64,

    //yes = tasety | goodServes | cheap,
    //no = discusting | badServes | expensive 
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
                        survey = Survey.tasety;
                    }
                    else
                    {
                        survey = Survey.discusting;
                    }
                    break;
                case 1:
                    if (answer == "yes")
                    {
                        survey |= Survey.goodServes;
                    }
                    else
                    {
                        survey |= Survey.badServes;
                    }
                    break;
                default:
                    if (answer == "yes")
                    {
                        survey |=  Survey.cheap;
                    }
                    else
                    {
                        survey |= Survey.expensive;
                    }
                    break;
            }
        }

        
        
        //AskQuestion("Was it tasety?", survey);
        //AskQuestion("Good Serves?", survey);
        //AskQuestion("Was it cheap?", survey);
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
            if (testResult == (testResult |= item))
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

    //static void AskQuestion(string question, Survey answers)
    //{
    //    Console.WriteLine(question);
    //    string answer = Console.ReadLine().ToLower();
    //    switch (answer.ToLower())
    //    {
    //        case "yes":
    //            answers = answers | Survey.yes;
    //            break;
    //        case "no":
    //            answers = answers | Survey.no;
    //            break;
    //        default:
    //            break;
    //    }
    //}
}

