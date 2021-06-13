using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //ball speed
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //Adding force to our ball when the game is initiated
        //GetComponent<Rigidbody>().AddForce(new Vector3(50, 500, 50));
    }

    // Update is called once per frame
    void Update()
    {
        //create variables that handle user input
        //float horizontalMove = Input.GetAxis("Horizontal");
        //float verticalMove = Input.GetAxis("Vertical");

        //apply direction to the ball using the variables we created above
        //GetComponent<Rigidbody>().AddForce(new Vector3(horizontalMove * speed, 0, verticalMove * speed));
        float inputX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float inputZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        GetComponent<Rigidbody>().transform.Translate(inputX, 0, inputZ);

    }
}
