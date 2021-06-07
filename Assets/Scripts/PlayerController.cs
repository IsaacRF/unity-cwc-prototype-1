using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float Speed = 25f;
    private float TurnSpeed = 75f;
    private float HorizontalInput;
    private float VerticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Get player inputs
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        // Move vehicle forward depending on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * VerticalInput);
        // Turn vehicle depending on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * TurnSpeed * HorizontalInput);
    }
}
