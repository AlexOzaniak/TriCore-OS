using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Kalkulacka
{
    internal class Calculating
    {
        internal void Calc()
        {
            Console.WriteLine("Zadaj priklad");
            string input = Console.ReadLine();

            List<string> elements = RozsekajNaList(input);

            if (elements == null || elements.Count == 0)
            {
                Console.WriteLine("Neplatny priklad.");
                return;
            }

            SolveList solver = new SolveList();

            // Safeguard against malformed bracket sequences
            int safetyCounter = 0;
            while (elements.Contains("("))
            {
                if (++safetyCounter > 1000) // avoid infinite loop on malformed input
                {
                    Console.WriteLine("Chyba v zátvorkách výrazu.");
                    return;
                }

                int intEnd = elements.IndexOf(")");
                if (intEnd == -1)
                {
                    Console.WriteLine("Zátvorky nie sú správne uzavreté.");
                    return;
                }

                int intStart = -1;
                for (int i = intEnd; i >= 0; i--)
                {
                    if (elements[i] == "(")
                    {
                        intStart = i;
                        break;
                    }
                }

                if (intStart == -1)
                {
                    Console.WriteLine("Zátvorky nie sú správne otvorené.");
                    return;
                }

                int numberOfElementsInBrackets = intEnd - intStart - 1;
                if (numberOfElementsInBrackets <= 0)
                {
                    // empty parentheses -> treat as zero or skip
                    elements.RemoveRange(intStart, intEnd - intStart + 1);
                    elements.Insert(intStart, "0");
                    continue;
                }

                List<string> inside = elements.GetRange(intStart + 1, numberOfElementsInBrackets);

                double betweenResult;
                try
                {
                    betweenResult = solver.SolveWholeList(inside);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Chyba pri vyhodnocovaní vnútorného výrazu: {ex.Message}");
                    return;
                }

                elements.RemoveRange(intStart, intEnd - intStart + 1);
                elements.Insert(intStart, betweenResult.ToString(System.Globalization.CultureInfo.InvariantCulture));
            }

            double finalResult;
            try
            {
                finalResult = solver.SolveWholeList(elements);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Chyba pri vyhodnocovaní výrazu: {ex.Message}");
                return;
            }

            Console.WriteLine($"Vysledok: {finalResult}");
        }

        // Tokenize an arithmetic expression into a list of tokens (numbers, operators, parentheses).
        // Supports decimal numbers and unary minus.
        private List<string> RozsekajNaList(string input)
        {
            var tokens = new List<string>();

            if (string.IsNullOrWhiteSpace(input))
                return tokens;

            string s = input.Replace(" ", "");
            var number = new StringBuilder();

            bool IsOperator(string t) => t == "+" || t == "-" || t == "*" || t == "/" || t == "^";

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (char.IsDigit(c) || c == '.')
                {
                    number.Append(c);
                    continue;
                }

                // Handle unary minus: if '-' and it's at start or previous token is an operator or '(' then it's part of number
                if (c == '-')
                {
                    bool unary = false;
                    if (tokens.Count == 0)
                        unary = true;
                    else
                    {
                        string prev = tokens.Last();
                        if (prev == "(" || IsOperator(prev))
                            unary = true;
                    }

                    if (unary)
                    {
                        number.Append(c);
                        continue;
                    }
                }

                if (number.Length > 0)
                {
                    tokens.Add(number.ToString());
                    number.Clear();
                }

                // Accept operators and parentheses as single-character tokens
                if ("+-*/^()".Contains(c))
                {
                    tokens.Add(c.ToString());
                }
                else
                {
                    // Ignore other characters but you may want to handle errors here
                }
            }

            if (number.Length > 0)
                tokens.Add(number.ToString());

            return tokens;
        }
    }
}
