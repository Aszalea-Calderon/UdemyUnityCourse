using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]//
    private float _enemySpeed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 8, 0);

    }

    // Update is called once per frame
    void Update()
    {
        TeleportToTop();
        //Enemy Speed
        transform.Translate(Vector3.down * _enemySpeed * Time.deltaTime);



        void TeleportToTop()
        {
            if (transform.position.y < -5f)
            {
                int xCount = Random.Range(-10, 10);
                float yCount = 7.6f;
                transform.position = new Vector3(xCount, yCount, 0);
            }
        }


    }
    private void OnTriggerEnter(Collider other)
    {

        // if item hitting enemy is lazor destory enemy
        if (other.tag == "Lazor")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            //DMG player
        }
        if (other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();

            if (player != null)
            {
                player.Damage();
            }
            //This grabs from other files
            Destroy(this.gameObject);
        }
    }
}
