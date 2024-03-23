using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject[] dogPrefab;
    private int dogKey;
    public static int dogCount = 3;
    public float time = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (dogCount > 0) && (!gameManager.showScreenLoseGame))
        {
            
            dogKey = Random.Range(0, dogPrefab.Length);
            Instantiate(dogPrefab[dogKey], transform.position, dogPrefab[dogKey].transform.rotation);

            dogCount--;
           

        }
    }

   
    
}
