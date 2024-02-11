using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 0.3f;
    int cnt = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemyFrag")
        {
            cnt++; print("hello");
            Destroy(collision.gameObject);
            if (cnt == 5)
            {
                Destroy(gameObject);
                print("hello");
                cnt = 0;
            }
        }
    }


}
