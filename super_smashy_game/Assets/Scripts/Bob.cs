using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour
{
    public float speed = 4f;
    public float height = 0.3f;

    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        
        float newY = Mathf.Sin(Time.time * speed) * (height * 0.05f) + pos.y;
        //Debug.Log(transform.position + " " + newY);
        gameObject.transform.position = new Vector3(pos.x, newY, pos.z);
    }
}
