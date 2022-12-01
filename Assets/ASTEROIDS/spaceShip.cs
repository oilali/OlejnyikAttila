
using UnityEngine;

public class spaceShip : MonoBehaviour
{

    [SerializeField] float acceleration;

    //[SerializeField] float decreaseSpeed;

    [SerializeField] float maxSpeed = 5;


    [SerializeField] KeyCode forwardButton = KeyCode.UpArrow;
    // [SerializeField] KeyCode backButton = KeyCode.DownArrow;

    [SerializeField] float angularSpeed = 90;

    [SerializeField] float drag = 0.3f;

    Vector3 velocity;

    // Update is called once per frame
    void FixedUpdate()
    {

        bool forward = Input.GetKey(forwardButton) || Input.GetKeyDown(KeyCode.W); /*UPARROW*/



        //  bool backward = Input.GetKey(backButton); /*UPARROW*/

        if (forward)
        {
            Vector3 direction = transform.up;

            velocity += direction * acceleration * Time.fixedDeltaTime;


        }

        float currentSpeed = velocity.magnitude;
        if (currentSpeed > maxSpeed)
        {


            velocity.Normalize();
            velocity *= maxSpeed;

            //currentSpeed = maxSpeed - 0.1f;

        }

        /* if (backward)
         {
             Vector3 direction = transform.up;

             velocity += direction * -acceleration * Time.deltaTime;


         }*/

        transform.position += velocity * Time.fixedDeltaTime;

        float rotationInput = Input.GetAxis("Horizontal");

        transform.Rotate(0, 0, -rotationInput * angularSpeed * Time.fixedDeltaTime);

        /*lasslás*/

        velocity *= 1 - (drag * Time.fixedDeltaTime);

    }
}
