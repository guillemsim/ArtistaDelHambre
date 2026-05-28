using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class IntScript_3: MonoBehaviour
{
    private bool _interact;
    private Light _light;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _interact = false;
        _light = GetComponent<Light>();

    }

    // Update is called once per frame
    void Update()
    {
        /// Luz de proximidad
        if(_interact == true)
        {
            _light.enabled = true;
        }
        else
        {
            _light.enabled = false;
        }
        
        /// Script Interaccion
        if(InputSystem.actions["Interact"].WasPressedThisFrame() == true && _interact == true)
        {
            SceneManager.LoadScene("Mapa_1");
            Debug.Log("Interaccion Correcta Con Objeto 3");
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Personaje")
        {
            _interact = true;
            //Debug.Log("_interact true");
        }

    }

        void OnTriggerExit(Collider col)
    {
        if(col.gameObject.name == "Personaje")
        {
            _interact = false;
            //Debug.Log("_interact false");
        }
    }
}
