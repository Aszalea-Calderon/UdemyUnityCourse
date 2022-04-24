using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazor : MonoBehaviour
{
    [SerializeField]
    private float _laserSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * _laserSpeed * Time.deltaTime);
        //when leaving if lazor at 7 y 
        //destory object
        if (transform.position.y > 7f)
        {
            Destroy(gameObject);
        }

    }

}
