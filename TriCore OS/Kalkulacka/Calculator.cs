using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Kalkulacka
{
    internal class Calculator
    {
         ExpressionSolver solver = new ExpressionSolver();

        public void Run()
        {
            string input = "";
            while (input != "end")
            { 
            Console.WriteLine("Enter your expression (e.g., 2 + (3 * 4) / 2):");
            input = Console.ReadLine().Trim();

            try
            {
                List<string> tokens = Tokenize(input);
                double result = ProcessBrackets(tokens);

                Console.WriteLine($"Result: {result}");
                File.AppendAllText("history.txt", $"{input} = {result}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            }
        }

        private double ProcessBrackets(List<string> tokens)
        {
            while (tokens.Contains("("))
            {
                int closingIndex = tokens.IndexOf(")");
                int openingIndex = -1;

                // Hľadáme najbližšiu otváraciu zátvorku k tej zatváracej
                for (int i = closingIndex; i >= 0; i--)
                {
                    if (tokens[i] == "(")
                    {
                        openingIndex = i;
                        break;
                    }
                }

                // Vyberieme vnútro zátvoriek
                int count = closingIndex - openingIndex - 1;
                List<string> subExpression = tokens.GetRange(openingIndex + 1, count);

                // Vypočítame vnútro cez solver
                double subResult = solver.Solve(subExpression);

                // Nahradíme zátvorky výsledkom
                tokens.RemoveRange(openingIndex, closingIndex - openingIndex + 1);
                tokens.Insert(openingIndex, subResult.ToString());
            }

            return solver.Solve(tokens);
        }

        private List<string> Tokenize(string input)
        {
            // Pridá medzery okolo operátorov pre ľahké rozdelenie
            string spaced = input.Replace("(", " ( ").Replace(")", " ) ")
                                 .Replace("+", " + ").Replace("-", " - ")
                                 .Replace("*", " * ").Replace("/", " / ");

            return spaced.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }
}
