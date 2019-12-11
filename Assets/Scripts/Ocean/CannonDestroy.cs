using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class CannonDestroy : MonoBehaviour
{
    public AudioSource destroy;

    private void OnTriggerEnter(Collider other)
    {
        destroy.Play();
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
