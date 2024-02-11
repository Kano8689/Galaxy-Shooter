using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galaxy : MonoBehaviour
{
    Renderer renderer;
    //Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float Yspeed = Time.time * 0.05f;
        renderer.material.SetTextureOffset("_MainTex", new Vector2(0, Yspeed));
    }
}
