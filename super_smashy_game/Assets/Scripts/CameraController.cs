using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Variables
    public Transform target;

    public Vector3 offset;

    public float rotationSpeed = 100f;
    private float currentRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentRotation -= Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;        
    }

    private void LateUpdate()
    {
        transform.position = target.position - offset;
        transform.LookAt(target.position);

        transform.RotateAround(target.position, Vector3.up, currentRotation);
    }
}
