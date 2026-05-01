using UnityEngine;
using UnityEngine.InputSystem;

public class InteractScript: MonoBehaviour
{
    bool _interact;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _interact = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(InputSystem.actions["Interact"].WasPressedThisFrame() == true && _interact == true)
        {
            Debug.Log("Interaccion Correcta");
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Personaje")
        {
            _interact = true;
            Debug.Log("_interact true");
        }

    }

        void OnTriggerExit(Collider col)
    {
        if(col.gameObject.name == "Personaje")
        {
            _interact = false;
            Debug.Log("_interact false");
        }
    }
}
