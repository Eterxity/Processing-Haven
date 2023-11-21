using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorScript : MonoBehaviour
{

    public float speed;
    public Vector3 direction;
    public List<GameObject> onBelt;

    // Gets the direction of the conveyor and sets the direction accordingly
    void Start()
    {

        Debug.Log(transform.rotation.eulerAngles.y);

        if (transform.rotation.eulerAngles.y == 0)
        {
            direction = new Vector3(-1, 0, 0);
        }

        if (transform.rotation.eulerAngles.y == 90)
        {
            direction = new Vector3(0, 0, 1);
        }

        if (transform.rotation.eulerAngles.y == 180)
        {
            direction = new Vector3(1, 0, 0);
        }

        if (transform.rotation.eulerAngles.y == 270)
        {
            direction = new Vector3(0, 0, -1);
        }

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i <= onBelt.Count - 1; i++)
        {
            onBelt[i].GetComponent<Rigidbody>().velocity = speed * direction;
        }
    }

    // When something collides with the belt
    private void OnCollisionEnter(Collision collision)
    {
        onBelt.Add(collision.gameObject);
    }

    // When something leaves the belt
    private void OnCollisionExit(Collision collision)
    {
        onBelt.Remove(collision.gameObject);
    }

}
