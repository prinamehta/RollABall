using UnityEngine;

public class BallController : MonoBehaviour
{

    public Rigidbody sphereRigidBody;
    public float ballSpeed = 2f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Calling the Start method");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero;
        if (Input.GetKeyDown(KeyCode.W))
        {
            inputVector += Vector2.up;
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            inputVector += Vector2.down;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            inputVector += Vector2.right;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            inputVector += Vector2.left;
        }

        Debug.Log("Resultant Vector: " +  inputVector);

        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        sphereRigidBody.AddForce(inputXZPlane * ballSpeed);
    }
}
