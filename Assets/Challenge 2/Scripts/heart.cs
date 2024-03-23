using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hearts : MonoBehaviour
{
    public bool help = true;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        gameManager.ballCountmin++;


    }
}
