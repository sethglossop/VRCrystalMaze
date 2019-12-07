using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Transporter : MonoBehaviour
{
    private Interactable interactable;
    public Transform transport;
    private TransportPlayer player;

    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<Interactable>();
        player = FindObjectOfType<TransportPlayer>();
    }

    // Update is called once per frame
    void Update()
    {

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
