using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class GrabTicket : MonoBehaviour
{
    private Interactable interactable;
    private LevelDome levelDome;

    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<Interactable>();
        levelDome = FindObjectOfType<LevelDome>();
    }

    private void HandHoverUpdate(Hand hand)
    {
        GrabTypes startingGrabType = hand.GetGrabStarting();
        bool isGrabEnding = hand.IsGrabEnding(this.gameObject);

        if (interactable.attachedToHand == null && startingGrabType != GrabTypes.None)
        {
            if (gameObject.CompareTag("Gold"))
            {
                levelDome.goldScore++;
            }
            else if (gameObject.CompareTag("Silver"))
            {
                levelDome.silverScore++;
            }
            Destroy(gameObject);
        }

    }
}

