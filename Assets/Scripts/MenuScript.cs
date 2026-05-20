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
        Application.Quit();
    }

    private void Update()
    {
 //       if (InputSystem.actions["Move"].WasPressedThisFrame = true)
        {
            
        }
    }
}
