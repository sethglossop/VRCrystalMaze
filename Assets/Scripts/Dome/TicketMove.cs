using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketMove : MonoBehaviour
{
    public GameObject ticket;
    private GameObject newTicket;
    private float maxradius = 2;
    private float maxhorizspeed = 2f;
    private float maxvertspeed = 2f;
    private float radius;
    private float horizspeed;
    private float vertspeed;

    // Start is called before the first frame update
    void Start()
    {
        horizspeed = Random.Range(0, maxhorizspeed);
        vertspeed = Random.Range(-maxvertspeed, maxvertspeed);
        radius = Random.Range(0.5f, maxradius);
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector3 circle = new Vector3(radius * Mathf.Cos(angle), 0, radius * Mathf.Sin(angle));
        newTicket = Instantiate(ticket, transform.position + circle, Random.rotation);
        newTicket.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, horizspeed, 0);
        transform.Translate(0, vertspeed*Time.deltaTime, 0);
        if (transform.position.y < 0 || transform.position.y > 4)
        {
            vertspeed = -vertspeed;
        }
    }
}
