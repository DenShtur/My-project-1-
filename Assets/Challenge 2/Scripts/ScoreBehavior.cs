using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBehavior : MonoBehaviour
{
    public int sc;
    private void OnTriggerEnter(Collider other)
    {
        
           gameManager.yourScore += sc;
        
    }
}
