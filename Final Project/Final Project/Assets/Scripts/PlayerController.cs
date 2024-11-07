using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float horizontalInput;

    public float speed = 20f;

    public float xRange = 10;

    public GameObject ArrowPrefab;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal") * speed;

        transform.Translate(horizontalInput * Time.deltaTime, 0,0);

        if (transform.position.x < -xRange) {

            transform.position = new UnityEngine.Vector3(-xRange, transform.position.y, transform.position.z);

        }

        if (transform.position.x > xRange) {

            transform.position = new UnityEngine.Vector3(xRange, transform.position.y, transform.position.z);

        }

        if (Input.GetKeyDown(KeyCode.Space)) {

            Instantiate(ArrowPrefab, transform.position, ArrowPrefab.transform.rotation);

        }

    }
}
