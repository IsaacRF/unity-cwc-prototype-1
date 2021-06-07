using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5.0f;
    public float TurnSpeed = 5.0f;
    public float HorizontalInput;
    public float VerticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * Speed * VerticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * TurnSpeed * HorizontalInput);
    }
}
