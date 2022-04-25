using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazor : MonoBehaviour
{
    [SerializeField]
    //Lazor Speed
    private float _laserSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //
    }

    // Update is called once per frame
    void Update()
    {
        //Lazor Speed
        transform.Translate(Vector3.up * _laserSpeed * Time.deltaTime);

        //Destroy lazor if out of window
        if (transform.position.y > 7f)
        {
            Destroy(gameObject);
        }

        //offset the lazor to spawn just above player. at .75 
    }

}
