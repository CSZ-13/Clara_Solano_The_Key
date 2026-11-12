using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speed = 5f;
    float horizontalMove;
    float verticalMove;
    CharacterController controller;


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
        Vector3 direcction = new Vector3(horizontalMove, 0, verticalMove);
        controller.Move(direcction * speed * Time.deltaTime);
    }


}
