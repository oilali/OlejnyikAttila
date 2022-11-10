
using UnityEngine;

public class rotate_obsticle : MonoBehaviour
{

    [SerializeField] float angularSpeed;

    // Update is called once per frame
    void Update()
    {

        float angle = angularSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, angle);

    }
}
