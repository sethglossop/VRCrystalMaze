using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Transporter : MonoBehaviour
{
    private Interactable interactable;
    public Transform transport;
    private TransportPlayer player;

    void Start()
    {
        interactable = GetComponent<Interactable>();
        player = FindObjectOfType<TransportPlayer>();
    }

    private void HandHoverUpdate(Hand hand)
    {
        GrabTypes startingGrabType = hand.GetGrabStarting();
        bool isGrabEnding = hand.IsGrabEnding(this.gameObject);

        if (interactable.attachedToHand == null && startingGrabType != GrabTypes.None)
        {
            player.Transport(transport);
        }
    }
}
