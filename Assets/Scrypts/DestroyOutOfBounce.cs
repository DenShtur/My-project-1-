using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounce : MonoBehaviour
{

    public float boundTop = 30f;
    private float boundLow = -10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > boundTop)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < boundLow)
        {
            Debug.Log("GameOver");
            Destroy(gameObject);
        }
    }
}
