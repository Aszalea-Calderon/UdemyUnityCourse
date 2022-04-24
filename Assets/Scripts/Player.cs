using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   //PUblic or Private Reference
    //Data Type (int (whole numbers), float (decimals), bool, string)
    // Every Variable has a name
    //Optional value assigned
    [SerializeField] //This allows designers 
    private float _speed = 10f; //must

    // Start is called before the first frame update
    void Start()
    {
        //Bring the player to (0,0,0) on start
        transform.position = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        //This is moving the character 5 meters per second. Multipling it by 5 it moves 5 meters per second
        // new Vector3(-1,0,0) * 5 * real time

        //OG MOVEMENT + float horizontalInput above and float verticalInput
        // transform.Translate(Vector3.up * verticalInput * _speed * Time.deltaTime);
        // transform.Translate(Vector3.right * horizontalInput * _speed * Time.deltaTime);

        //ALL IN ONE movement optimal
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * _speed * Time.deltaTime);

        //If player position on the y is greater than 0
        //y position = 0
        // else if position on the y is less thatn -3.8f
        if (transform.position.y >= 0)
        {
            //This is keeping us restrained to not going above 0 i.e too high.
            // We user transform.position.x as we want it to KEEP its current position 
            transform.position = new Vector3(transform.position.x, 0, 0);
        } //We use else if if we are using the SAME properity as before i.e transfrom.position.y >=0
        else if (transform.position.y <= -3.8f)
        {
            //THis keeps it from going too low
            transform.position = new Vector3(transform.position.x, -3.8f, 0);
        }
    }
}
