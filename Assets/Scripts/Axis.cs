using UnityEngine;

public class Axis : MonoBehaviour
{
    public GameObject axisX;
    public GameObject axisY;
    public int gridSize;

    void Start()
    {
        DrawAxes();
    }

    void DrawAxes()
    {
        for (int i = -gridSize; i <= gridSize; i++)
        {
            GameObject instanceX = Instantiate(axisX, new Vector3(i, 0, 0), Quaternion.identity);
            instanceX.transform.parent = transform;
            GameObject instanceY = Instantiate(axisY, new Vector3(0, i, 0), Quaternion.identity);
            instanceY.transform.parent = transform;
        }
    }
}