using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public string wallFormula;
    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        DrawWall();
    }

    void DrawWall()
    {
        List<Vector3> points = new List<Vector3>();
        for (float x = -gridSize; x <= gridSize; x += 0.1f)
        {
            float y = FormulaParser.ParseFormula(wallFormula, x);
            points.Add(new Vector3(x, y, 0));
        }

        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPositions(points.ToArray());
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
            Destroy(other.gameObject);
        }
    }
}