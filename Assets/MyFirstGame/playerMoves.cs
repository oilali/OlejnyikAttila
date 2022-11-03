
using UnityEngine;

public class playerMoves : MonoBehaviour
{

    [SerializeField] float speed;


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
        direction.Normalize(); //mert különben a jobbra-fel az x-y átfogón fog menni, ami nagyobb, mint a csak x, és csak y, és ezért nagyobb a sebesség. 
        Vector3 velocity = direction * speed;

        transform.position += velocity * howQuick;

        if (direction != Vector3.zero)
        {

            transform.rotation = Quaternion.LookRotation(direction);

        }

    }
}
