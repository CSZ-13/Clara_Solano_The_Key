using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speed = 5f;
    float horizontalMove;
    float verticalMove;
    CharacterController controller;
    public float gravity = -9.81f;
    public float verticalSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        if (controller.isGrounded == true)
        {
            verticalSpeed = 0f;
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                verticalSpeed = 3f;   
            }
        }
        verticalSpeed += gravity * Time.deltaTime;

        Vector3 direcction = new Vector3(horizontalMove, verticalSpeed, verticalMove);
        controller.Move(direcction * speed * Time.deltaTime);
    }

}
