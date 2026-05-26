using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MenuScript : MonoBehaviour
{

    public void InicioJuego()
    {
        SceneManager.LoadScene("Mapa_1");
    }

    public void ExitJuego()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    private void Update()
    {
        {
            
        }
    }
}
