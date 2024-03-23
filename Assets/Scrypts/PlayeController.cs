using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeController : MonoBehaviour
{

    public float horizintalInput;
    public float playerSpeed = 15.0f;

    public float playerRangeMove = 15f;
    public float yOffset = 1.2f;
    public GameObject[] foodPrefabPlayer;
    private int foodKey;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float spawnHeight = transform.position.y + yOffset;

            foodKey = Random.Range(0, foodPrefabPlayer.Length);

            Instantiate(foodPrefabPlayer[foodKey], new Vector3(transform.position.x, spawnHeight, transform.position.z), foodPrefabPlayer[foodKey].transform.rotation);

        }
        if (transform.position.x < -playerRangeMove)
        {
            transform.position = new Vector3(-playerRangeMove, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > playerRangeMove)
        {
            transform.position = new Vector3(playerRangeMove, transform.position.y, transform.position.z);
        }
        horizintalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * playerSpeed * horizintalInput * Time.deltaTime);
    }
}
