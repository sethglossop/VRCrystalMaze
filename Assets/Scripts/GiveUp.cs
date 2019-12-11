using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using UnityEngine.SceneManagement;

public class GiveUp : MonoBehaviour
{
    private Interactable interactable;
    public string zone;

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
            if (zone == "Aztec")
            {
                Crystals.Aztec = 2;
            }
            else if (zone == "Medieval")
            {
                Crystals.Medieval = 2;
            }
            else if (zone == "Futuristic")
            {
                Crystals.Futuristic = 2;
            }
            else if (zone == "Ocean")
            {
                Crystals.Ocean = 2;
            }
            SceneManager.LoadScene("Dome");
        }
    }
}
