using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static float _timeRemaining; // Variable tiempo maximo 
    public bool _timerIsRunning;

    private void Awake()
    {
        _timeRemaining = 300;
        DontDestroyOnLoad(gameObject);
    }
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
        Debug.Log("tiempo" + _timeRemaining);        
    }
    void FinJuego()
    {
        SceneManager.LoadScene("Mapa_Fin");
    }
}