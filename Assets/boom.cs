using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class boom : MonoBehaviour
{
    public Rigidbody rb;

    public PlayableDirector Timeline;

    void OnCollisionEnter(Collision collisionInfo)
    {
        //if (collisionInfo.)
        //Debug.Log("yoink");
        if (collisionInfo.collider.tag == "turret")
        {
            Debug.Log("Yeet!");
            Timeline.Play();
        }
    }
}




