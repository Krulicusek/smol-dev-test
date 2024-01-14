using UnityEngine;

public class SpeedController : MonoBehaviour
{
    public float gameSpeed = 1f;
    public float fastForwardSpeed = 2f;
    private bool isFastForward = false;

    void Update()
    {
        if (isFastForward)
        {
            Time.timeScale = fastForwardSpeed;
        }
        else
        {
            Time.timeScale = gameSpeed;
        }
    }

    public void ToggleFastForward()
    {
        isFastForward = !isFastForward;
    }
}