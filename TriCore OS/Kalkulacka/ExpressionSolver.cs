using System;
using System.Collections.Generic;
using System.Globalization;

public class ExpressionSolver
{
    public double Solve(List<string> elements)
    {
        // Vytvoríme pracovnú kópiu, aby sme si nepokazili pôvodný List
        List<string> workList = new List<string>(elements);

        // 1. FÁZA: Násobenie a delenie (priorita)
        for (int i = 0; i < workList.Count; i++)
        {
            if (workList[i] == "*" || workList[i] == "/")
            {
                double a = double.Parse(workList[i - 1], CultureInfo.InvariantCulture);
                double b = double.Parse(workList[i + 1], CultureInfo.InvariantCulture);
                double res = (workList[i] == "*") ? a * b : a / b;

                workList[i - 1] = res.ToString(CultureInfo.InvariantCulture);
                workList.RemoveAt(i); // Odstráni operátor
                workList.RemoveAt(i); // Odstráni druhé číslo
                i--; // Posunieme sa späť, aby sme nepreskočili ďalší prvok
            }
        }

        // 2. FÁZA: Sčítanie a odčítanie
        double result = double.Parse(workList[0], CultureInfo.InvariantCulture);
        for (int i = 1; i < workList.Count; i += 2)
        {
            string op = workList[i];
            double nextVal = double.Parse(workList[i + 1], CultureInfo.InvariantCulture);

            if (op == "+") result += nextVal;
            else if (op == "-") result -= nextVal;
        }

        return result;
    }
}