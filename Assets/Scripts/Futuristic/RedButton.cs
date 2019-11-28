using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class RedButton : MonoBehaviour
{
    private Interactable interactable;
    private bool on = false;
    public LightColour lamp;

    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<Interactable>();
    }

    void Update()
    {

    }

    private void HandHoverUpdate(Hand hand)
    {
        GrabTypes startingGrabType = hand.GetGrabStarting();
        bool isGrabEnding = hand.IsGrabEnding(this.gameObject);

        if (interactable.attachedToHand == null && startingGrabType != GrabTypes.None)
        {
            lamp.Red();
            OnOff();
        }
    }

    private void OnOff()
    {
        on = !on;
        if (on)
        {
            transform.position = transform.position + new Vector3(0, -0.03f, 0);
        }
        else
        {
            transform.position = transform.position + new Vector3(0, 0.03f, 0);
        }
    }

}
