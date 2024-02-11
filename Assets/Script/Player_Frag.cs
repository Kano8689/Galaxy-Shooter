using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Player_Frag : MonoBehaviour
{
    public GameObject bulletPlaceholder, enemyFragPlaceholder;//, userFragPlaceholder, enemyFragPaceholder;
    public GameObject Bullets, enemyFrag;
    //float speed = 0.001f;
    //float fragRotation = 0f;
    int cnt = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("generateBullets", 1f, 0.3f);

        generateenemyFrag();
    }

    // Update is called once per frame
    void Update()
    {
        touchMovementOnFrag();
    }

    void touchMovementOnFrag()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            // touch2 = touch1
            //float half1 = Screen.width / 2;
            //float half2 = Screen.height / 2;

            if (touch.phase == TouchPhase.Moved)
            {
                //float Xmax = Mathf.Clamp(transform.position.x, -1.18f, 1.18f);
                //float Ymax = Mathf.Clamp(transform.position.x, -4.38f, 4.4f);
                transform.position = new Vector2(touch.position.x, touch.position.y);
            }
        }

        //if (touch1.position.x < half1)
        //{
        //    //left side
        //    float max = Mathf.Clamp(transform.position.x - speed, -1.18f, 1.18f);
        //    transform.position = new Vector2(max, transform.position.y);
        //}
        //if (touch1.position.x > half1)
        //{
        //    //right side
        //    float max = Mathf.Clamp(transform.position.x + speed, -1.18f, 1.18f);
        //    transform.position = new Vector2(max, transform.position.y);
        //}
        //if (touch1.position.y > half2)
        //{
        //    //up side
        //    float max = Mathf.Clamp(transform.position.y + speed, -4.38f, 4.4f);
        //    transform.position = new Vector2(transform.position.x, max);
        //}
        //if (touch1.position.y < half2)
        //{
        //    //down side
        //    float max = Mathf.Clamp(transform.position.y - speed, -4.38f, 4.4f);
        //    transform.position = new Vector2(transform.position.x, max);
        //}

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    fragRotation += Time.deltaTime * 20f;
        //    float maxRotation = Mathf.Clamp(transform.position.z + fragRotation, -10f, 0f);
        //    transform.rotation = Quaternion.Euler(0, 0, fragRotation);
        //    float max = Mathf.Clamp(transform.position.x - speed, -1.18f, 1.18f);
        //    transform.position = new Vector2(max, transform.position.y);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    fragRotation -= Time.deltaTime * 20f;
        //    float maxRotation = Mathf.Clamp(transform.position.z - fragRotation, 0f, 10f);
        //    transform.rotation = Quaternion.Euler(0, 0, fragRotation);
        //    float max = Mathf.Clamp(transform.position.x + speed, -1.18f, 1.18f);
        //    transform.position = new Vector2(max, transform.position.y);
        //}
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    float max = Mathf.Clamp(transform.position.y + speed, -4.38f, 4.4f);
        //    transform.position = new Vector2(transform.position.x, max);
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    float max = Mathf.Clamp(transform.position.y - speed, -4.38f, 4.4f);
        //    transform.position = new Vector2(transform.position.x, max);
        //}

        //if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
        //{
        //    fragRotation = 0f;
        //    transform.rotation = Quaternion.Euler(0, 0, 0);
        //}
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "enemyFrag")
    //    {
    //        cnt++;
    //        Destroy(collision.gameObject);
    //        if (cnt == 5)
    //        {
    //            Destroy(gameObject);
    //            print("hello");
    //        }
    //    }
    //}

    void generateBullets()
    {
        float posX = transform.position.x;
        float posY = transform.position.y;
        Vector2 pos = new Vector2(posX, posY);
        Instantiate(Bullets, pos, Quaternion.identity, bulletPlaceholder.transform);
    }

    void generateenemyFrag()
    {
        Vector2 pos = new Vector2(0, 3.35f);
        Instantiate(enemyFrag, pos, Quaternion.identity, enemyFragPlaceholder.transform);
    }

}
