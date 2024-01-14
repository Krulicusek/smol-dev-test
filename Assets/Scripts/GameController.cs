using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public PlayerController playerController;
    public AIController aiController;
    public MapController mapController;
    public SpeedController speedController;

    void Start()
    {
        mapController.LoadMap();
        StartGame();
    }

    void Update()
    {
        if (playerController.IsGameOver())
        {
            EndGame();
        }
    }

    public void StartGame()
    {
        playerController.StartGame();
        aiController.StartGame();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        // Implement game over logic here
    }

    public void SpeedUpGame()
    {
        speedController.SpeedUp();
    }
}