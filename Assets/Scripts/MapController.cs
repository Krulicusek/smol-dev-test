using UnityEngine;

public class MapController : MonoBehaviour
{
    public GameObject[] lanes;
    public GameObject[] jungles;
    public GameObject baseLocation;
    public GameObject[] towerLocations;

    void Start()
    {
        LoadMap();
    }

    public void LoadMap()
    {
        // Load the base
        Instantiate(baseLocation, new Vector3(0, 0, 0), Quaternion.identity);

        // Load the lanes
        for (int i = 0; i < lanes.Length; i++)
        {
            Instantiate(lanes[i], new Vector3(i * 10, 0, 0), Quaternion.identity);
        }

        // Load the jungles
        for (int i = 0; i < jungles.Length; i++)
        {
            Instantiate(jungles[i], new Vector3(i * 10, 0, 10), Quaternion.identity);
        }

        // Load the towers
        for (int i = 0; i < towerLocations.Length; i++)
        {
            Instantiate(towerLocations[i], new Vector3(i * 10, 0, 20), Quaternion.identity);
        }
    }
}