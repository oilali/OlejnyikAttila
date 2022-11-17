using UnityEngine;

public class cameraMove : MonoBehaviour
{

    [SerializeField] Transform player;
    [SerializeField] float maxVerticalDistance;

    // Update is called once per frame
    void Update()
    {

        Vector3 playerPos = player.position;

        float y = transform.position.y;

        if (y < playerPos.y - maxVerticalDistance)
        {

            y = playerPos.y - maxVerticalDistance;

        }

        if (y < playerPos.y + maxVerticalDistance)
        {

            y = playerPos.y + maxVerticalDistance;

        }

        transform.position = new Vector3(playerPos.x, playerPos.y, transform.position.z);

    }
}
