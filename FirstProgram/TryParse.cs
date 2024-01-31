using System;


namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int number, numTemp;
            if (int.TryParse(temperature, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                System.Console.WriteLine("value entered  , was no number , 0 set as a temperature");
            }
            if (numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }

            if (numTemp == 20)
            {
                Console.WriteLine("Pants and Pull Over should be fine");
            }

            if (numTemp > 20)
            {
                Console.WriteLine("Shorts are enough today");
            }
            NestedIf.Program.NestedIf();
            RegisteringAndLogginIn.Program.RegisterAndLogging();
            Switch_Statement.Program.SwitchStatement();
            HelloWorld1.Program.Operation();
            OperatorsC.Program.Operator();
            TryAndCatchC.Program.TryAndCatch();
            HelloWorld1.TypeConversion.TypeConversion1();
            IfStatementsChallenge2.Program.CheckHighscore(250, "Maria");
            IfStatementsChallenge2.Program.CheckHighscore(315, "Michael");
            IfStatementsChallenge2.Program.CheckHighscore(350, "Denis");
            Enhanced_If_Statements.Program.TernaryOperator1();
            ForLoop.Program.ForLoop();
            DoWhileLoop.Program.DoWhile();
            WhileLoop.Program.While();
            BreakContinue.Program.BreakAndContinue();

            Console.Read();
        }




    }
}
