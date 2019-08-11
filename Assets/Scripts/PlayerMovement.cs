using System.Collections;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    private void FixedUpdate()
    {
        // controls with WASD

        if (Input.GetKey("d"))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(0.6f, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(-0.6f, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(0, 0, 0.6f);
        }

        if (Input.GetKey("s"))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(0, 0, -0.6f);
        }


        // die if player drops below a certain point
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
