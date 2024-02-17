using System;
using UnityEngine;

public class FormulaParser : MonoBehaviour
{
    public static Func<float, float> ParseFormula(string formula)
    {
        Func<float, float> parsedFormula = null;

        if (formula.Contains("^"))
        {
            string[] parts = formula.Split('^');
            float power = float.Parse(parts[1]);
            parsedFormula = x => Mathf.Pow(x, power);
        }
        else if (formula.Contains("="))
        {
            string[] parts = formula.Split('=');
            float constant = float.Parse(parts[1]);
            parsedFormula = x => constant;
        }
        else
        {
            Debug.LogError("Invalid formula");
        }

        return parsedFormula;
    }
}