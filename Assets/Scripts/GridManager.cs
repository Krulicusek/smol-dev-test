using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int gridSize;
    public GameObject axisX;
    public GameObject axisY;

    void Start()
    {
        gridSize = 10;
        DrawGrid();
    }

    void DrawGrid()
    {
        for (int i = -gridSize; i <= gridSize; i++)
        {
            GameObject instanceX = Instantiate(axisX);
            instanceX.transform.position = new Vector3(i, 0, 0);
            GameObject instanceY = Instantiate(axisY);
            instanceY.transform.position = new Vector3(0, i, 0);
        }
    }

    public void UpdateGrid()
    {
        GameObject[] axes = GameObject.FindGameObjectsWithTag("Axis");
        foreach (GameObject axis in axes)
        {
            Destroy(axis);
        }
        DrawGrid();
    }
}