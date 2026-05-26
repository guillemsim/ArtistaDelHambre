using UnityEngine;
using UnityEngine.InputSystem;

public class PausaScript : MonoBehaviour

{
    public static bool _isPaused;
    public GameObject _MenuPausa;

    private void Start()
    {
        _MenuPausa.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (InputSystem.actions["Pause"].WasPressedThisFrame() == true)
         {
            if (_isPaused == false)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
        Debug.Log("Pausa"+ _isPaused);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        _MenuPausa.SetActive(true);
        _isPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        _MenuPausa.SetActive(false);
        _isPaused = false;
    }
}