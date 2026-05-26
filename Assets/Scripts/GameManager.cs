using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float _timeRemaining; // Variable tiempo maximo 
    public bool _timerIsRunning;

    private void Start()
    {
        _timerIsRunning = true;
    }

    private void Update()
    {
        /// Tiempo
        if (_timerIsRunning)
        {
            if (_timeRemaining > 0)
                {
                _timeRemaining -= Time.deltaTime; // Timer
                }
            else
                {
                Debug.Log("Tiempo Agotado");
                _timeRemaining = 0;
                _timerIsRunning = false; // Final del timer
                FinJuego();
                }
        }        
    }
    void FinJuego()
    {
        SceneManager.LoadScene("Mapa_Fin");
    }
}