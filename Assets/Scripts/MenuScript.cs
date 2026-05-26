using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MenuScript : MonoBehaviour
{

    public void InicioJuego(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
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
