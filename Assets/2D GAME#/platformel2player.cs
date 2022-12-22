using UnityEngine;

public class platformel2player : MonoBehaviour
{

    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] HealthObject healthObject;
    [SerializeField] float jumpVelocity;
    [SerializeField] float moveForce;
    [SerializeField] int maxJumps;

    bool isGrounded;
    int currentJump;

    JumpMultiplier jumpPlatform;

    private void OnValidate()
    {

        rigidbody = GetComponent<Rigidbody2D>();
        healthObject = GetComponent<HealthObject>();

    }

    // Update is called once per frame
    void Update()
    {

        if (healthObject != null && healthObject.isDead()) { return; }

        if ((isGrounded || currentJump > 0) && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = Vector2.zero;

            Vector2 jump = Vector2.up * jumpVelocity;



            rigidbody.AddForce(jump, ForceMode2D.Impulse); // ForceMode2D.Force

            if (!isGrounded) { currentJump--; }

        }

        if (jumpPlatform != null)
        {
            Vector2 jump = Vector2.up * jumpVelocity;
            // jump *= 2;
            rigidbody.AddForce(jump * jumpPlatform.mult, ForceMode2D.Impulse);

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

        //   Debug.Log("Collide" + collision.otherCollider.name);
        jumpPlatform = collision.gameObject.GetComponent<JumpMultiplier>();




    }

    void OnCollisionExit2D(Collision2D collision)
    {

        isGrounded = false;
        jumpPlatform = null;


        Debug.Log("Exit");
    }

    void FixedUpdate()
    {

        if (healthObject != null && healthObject.isDead()) { return; }

        float inputX = Input.GetAxis("Horizontal");

        /*
        if (inputX != 0)
        {

            float direction = Mathf.Sign(inputX); //ha pozitív 1, ha negatív 0 - ez adja meg az irányt.
            Vector3 scale = transform.localScale;
            transform.localScale = new Vector3(direction * Mathf.Abs(scale.x), scale.x, scale.z);

        }*/

        if (inputX > 0)
        {

            transform.rotation = Quaternion.Euler(0, 0, 0);


        }
        else if (inputX < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);

        }

    }

}
