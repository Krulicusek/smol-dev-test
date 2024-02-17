using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject baseElement;
    public GameObject projectileElement;
    public GameObject wallElement;
    public GameObject gridElement;
    public GameObject axisElement;

    public float baseHP;
    public Vector2 basePosition;
    public float projectileSpeed;
    public string wallFormula;
    public Vector2 gridSize;
    public Vector2 axisX;
    public Vector2 axisY;

    private void Start()
    {
        baseHP = baseElement.GetComponent<Base>().width;
        basePosition = baseElement.transform.position;
        projectileSpeed = projectileElement.GetComponent<Projectile>().speed;
        gridSize = gridElement.GetComponent<GridManager>().size;
        axisX = axisElement.GetComponent<Axis>().axisX;
        axisY = axisElement.GetComponent<Axis>().axisY;
    }

    public void CreateWall(string formula)
    {
        wallFormula = formula;
        wallElement.GetComponent<Wall>().CreateWall(formula);
    }

    public void LaunchProjectile()
    {
        projectileElement.GetComponent<Projectile>().Launch();
    }

    public void CalculateDamage()
    {
        baseHP -= projectileElement.GetComponent<Projectile>().damage;
        if (baseHP <= 0)
        {
            GameOver();
        }
    }

    public void ParseFormula(string formula)
    {
        wallFormula = formula;
        wallElement.GetComponent<Wall>().ParseFormula(formula);
    }

    public void UpdateGrid()
    {
        gridElement.GetComponent<GridManager>().UpdateGrid();
        axisElement.GetComponent<Axis>().UpdateAxis();
    }

    private void GameOver()
    {
        // Game over logic here
    }
}