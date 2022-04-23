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
        transform.Translate(Vector3.up * verticalInput * _speed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontalInput * _speed * Time.deltaTime);

    }
}
