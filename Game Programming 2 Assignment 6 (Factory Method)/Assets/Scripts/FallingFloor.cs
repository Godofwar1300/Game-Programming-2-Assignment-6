/*
* (Christopher Green)
* (FallingFloor.cs)
* (Assignment 6)
* (This is the code for the falling platform that causes it to fall and then be destroyed)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingFloor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player is on me me, starting Coroutine!");
            StartCoroutine(ObjectFallAndDestroy());
        }
    }

    IEnumerator ObjectFallAndDestroy()
    {
        yield return new WaitForSeconds(1f);
        this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        this.gameObject.GetComponent<Rigidbody>().useGravity = true;
        yield return new WaitForSeconds(1f);
        Destroy(this.gameObject);
    }

}
