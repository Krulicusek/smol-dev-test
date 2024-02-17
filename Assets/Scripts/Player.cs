using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public string wallFormula;
    public GameObject wallPrefab;
    private Wall wall;

    void Start()
    {
        wall = wallPrefab.GetComponent<Wall>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            wallFormula = Input.inputString;
            CreateWall(wallFormula);
        }
    }

    void CreateWall(string formula)
    {
        wall.formula = formula;
        wall.Create();
        SendMessage("WallCreated");
    }
}