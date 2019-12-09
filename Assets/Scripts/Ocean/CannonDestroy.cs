using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class CannonDestroy : MonoBehaviour
{
    public AudioSource destroy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        destroy.Play();
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
