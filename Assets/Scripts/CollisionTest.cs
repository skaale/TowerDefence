using UnityEngine;
using System.Collections;

public class CollisionTest : MonoBehaviour

{
    void OnCollisionEnter(Collision col)
    {
        
        

        Debug.Log(gameObject.name + " has collided with " + col.gameObject.name + col.contacts[0].point + col.contacts[0].normal + col.relativeVelocity );

    }


    void OnTriggerEnter(Collider other)
    {

        Debug.Log(gameObject.name + " was Triggered by " + other.gameObject.name); 

    }


}
