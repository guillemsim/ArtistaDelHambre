using UnityEngine;
using UnityEngine.InputSystem;

public class PausaScript : MonoBehaviour

{
    public static bool _isPaused;
    public GameObject _MenuPausa;

    private void Start()
    {
        _MenuPausa.SetActive(false);
    }

    private void Update()
    {
        if (InputSystem.actions["Pause"].WasPressedThisFrame())
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
        
        _MenuPausa.SetActive(true);
        _isPaused = true;
        //Time.timeScale = 0;
        Debug.Log("Pausado");
    }

    public void ResumeGame()
    {
        
        _MenuPausa.SetActive(false);
        _isPaused = false;
        //Time.timeScale = 1;
        Debug.Log("Continuando");
    }
}