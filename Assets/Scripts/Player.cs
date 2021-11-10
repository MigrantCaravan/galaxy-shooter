using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float _speed = 12.5f;
    // Start is called before the first frame update
    void Start()
    {
        // take current position and attached to 0
        transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
    }
    void CalculateMovement()
    {
    float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");
    if(transform.position.y >= 3)
    {
    transform.position = new Vector3(transform.position.x, 3, 0); 
    }
    else if(transform.position.y <= -1.2f)
    {
    transform.position = new Vector3(transform.position.x, -1.2f, 0);
    }

// transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -1.2f, 3), 0);

    if(transform.position.x < -6.89f)
    {
    transform.position = new Vector3(19.1f, transform.position.y, 0);
    } 
    else if(transform.position.x > 19.1f)
    {
    transform.position = new Vector3(-6.89f, transform.position.y, 0);
    }

        // transform.Translate(Vector3.right * horizontalInput * _speed * Time.deltaTime);
        // transform.Translate(Vector3.up * verticalInput * _speed * Time.deltaTime);
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate( direction * _speed * Time.deltaTime);
    }
}
