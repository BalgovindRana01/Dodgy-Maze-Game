using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        PrintInstructions();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * moveSpeed;
        Vector3 move = new Vector3(xValue, 0, zValue) * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + move);
    }
}