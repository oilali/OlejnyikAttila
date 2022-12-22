
using UnityEngine;

public class playerMoves : MonoBehaviour
{

    [SerializeField] float speed;

    [SerializeField] float angularSpeed = 180;

    [SerializeField] Animator anim;

    private void OnValidate()
    {
        if (anim == null)
        {

            anim = GetComponent<Animator>();

        }
    }


    // Update is called once per frame
    void Update()
    {

        bool isRightPressed = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
        bool isLeftPressed = Input.GetKey(KeyCode.LeftArrow);
        bool isUpPressed = Input.GetKey(KeyCode.UpArrow);
        bool isDownPressed = Input.GetKey(KeyCode.DownArrow);
        bool isSpacePressed = Input.GetKey(KeyCode.Space);

        float howQuick = Time.deltaTime;

        float x = 0;


        if (isRightPressed)
        {
            x = 1;

        }
        else if (isLeftPressed)
        {

            x = -1;

        }
        else { x = 0; }


        float z = isUpPressed ? 1 :
            (isDownPressed) ? -1 : 0;


        Vector3 direction = new Vector3(x, 0, z);
        direction.Normalize(); //mert k�l�nben a jobbra-fel az x-y �tfog�n fog menni, ami nagyobb, mint a csak x, �s csak y, �s ez�rt nagyobb a sebess�g. 
        Vector3 velocity = direction * speed;

        transform.position += velocity * howQuick;

        bool isMoving = velocity != Vector3.zero;
        anim.SetBool("isRunning", isMoving);

        if (direction != Vector3.zero)
        {

            // transform.rotation = Quaternion.LookRotation(direction);
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            Quaternion currentRotation = transform.rotation;
            float maxStepInAngle = angularSpeed * Time.deltaTime;

            transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, maxStepInAngle);


        }

    }
}
