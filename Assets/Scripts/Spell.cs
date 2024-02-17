using UnityEngine;
using System;

public class Spell : MonoBehaviour
{
    public string wallFormula;
    private Wall wall;

    void Start()
    {
        wall = GetComponent<Wall>();
    }

    public void CastSpell(string formula)
    {
        wallFormula = formula;
        CreateWall();
    }

    private void CreateWall()
    {
        try
        {
            wall.CreateWall(wallFormula);
        }
        catch (Exception e)
        {
            Debug.Log("Invalid formula: " + e.Message);
        }
    }
}