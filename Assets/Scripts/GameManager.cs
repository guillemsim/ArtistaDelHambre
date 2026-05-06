using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float timeRemaining = 60; // Set initial time in seconds
    public bool timerIsRunning = false;
    public Text timeText; // Reference to UI Text for displaying time

    private void Start()
    {
        timerIsRunning = true; // Start the timer automatically
    }

    private void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
                {
                timeRemaining -= Time.deltaTime; // Decrease time
                DisplayTime(timeRemaining); // Update UI
                }
            else
                {
                Debug.Log("Time's up!");
                timeRemaining = 0;
                timerIsRunning = false; // Stop the timer
                }
        }
    }

private void DisplayTime(float timeToDisplay)
    {
    timeToDisplay += 1; // Adjust for display rounding
    int minutes = Mathf.FloorToInt(timeToDisplay / 60);
    int seconds = Mathf.FloorToInt(timeToDisplay % 60);
    timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Format as MM:SS
    }
}