using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public GameObject Player;

    public float horizontalInput;

    public float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal") * speed;

        Player.transform.Translate(horizontalInput * Time.deltaTime, 0,0);

    }
}
