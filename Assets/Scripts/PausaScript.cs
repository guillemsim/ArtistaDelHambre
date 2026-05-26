using UnityEngine;
using UnityEngine.InputSystem;

public class PausaScript : MonoBehaviour

{
    public bool isPaused;
    public GameObject _MenuPausa;

    private void Start()
    {
        _MenuPausa.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (InputSystem.actions["Pause"].WasPressedThisFrame() == true)
         {
            // Toggle pause state on Escape key press
            isPaused = !isPaused;
            if (isPaused)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
        Debug.Log("Pausa"+ isPaused);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        _MenuPausa.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        _MenuPausa.SetActive(false);
    }
}