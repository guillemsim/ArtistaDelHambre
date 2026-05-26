using System.Net.Sockets;
using UnityEngine;

public class NPC_Script : MonoBehaviour
{
    private Vector3 _PosInicial;
    private float _NPCVelocidad = 5f;
    private bool _PlayerLejos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _PosInicial = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(_PlayerLejos)
        {
            float _Mov = _NPCVelocidad * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, _PosInicial, _Mov);
        }
        
    }
        void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Personaje")
        {
            _PlayerLejos = false;
        }

    }

        void OnTriggerExit(Collider col)
    {
        if(col.gameObject.name == "Personaje")
        {
            _PlayerLejos = true;
        }
    }
}
