using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class BeginLevel : MonoBehaviour
{
    private Interactable interactable;
    public GameObject spawn;
    public GameObject panelLeft;
    public GameObject panelRight;
    public GameObject scoreTimer;

    void Start()
    {
        interactable = GetComponent<Interactable>();
    }

    private void HandHoverUpdate(Hand hand)
    {
        GrabTypes startingGrabType = hand.GetGrabStarting();
        bool isGrabEnding = hand.IsGrabEnding(this.gameObject);

        if (interactable.attachedToHand == null && startingGrabType != GrabTypes.None)
        {
            spawn.SetActive(true);
            panelRight.SetActive(false);
            panelLeft.SetActive(false);
            scoreTimer.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
