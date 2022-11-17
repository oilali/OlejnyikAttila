using UnityEngine;

public class platformel2player : MonoBehaviour
{

    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] float jumpForce;
    [SerializeField] float moveForce;
    [SerializeField] int maxJumps;

    bool isGrounded;
    int currentJump;

    private void OnValidate()
    {

        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        if ((isGrounded || currentJump > 0) && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = Vector2.zero;
            rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); // ForceMode2D.Force

            if (!isGrounded) { currentJump--; }

        }
        /*
                if (Input.GetKey(KeyCode.LeftArrow))
                {

                    rigidbody.AddForce(Vector2.left * moveForce, ForceMode2D.Force);

                }

                if (Input.GetKey(KeyCode.RightArrow))
                {

                    rigidbody.AddForce(Vector2.right * moveForce, ForceMode2D.Force);

                }
        */

        float inputX = Input.GetAxis("Horizontal");
        Debug.Log(inputX);

        Vector2 velocity = new Vector2(inputX * moveForce, rigidbody.velocity.y);

        rigidbody.velocity = velocity;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        currentJump = maxJumps;

        isGrounded = true;

        Debug.Log("Collide" + collision.otherCollider.name);
    }

    void OnCollisionExit2D(Collision2D collision)
    {

        isGrounded = false;

        Debug.Log("Exit");
    }

    private void FixedUpdate()
    {

    }

}
