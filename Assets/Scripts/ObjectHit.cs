using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log("Bumped into a wall!");
        if (other.gameobject.tag == "player")
        {
            getcomponent<meshrenderer>().material.color = color.red;
            gameobject.tag = "hit";
        }
    }
}
