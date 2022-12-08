
using UnityEngine;

public class rotate_obsticle : MonoBehaviour
{

    [SerializeField] float angularSpeed;
    [SerializeField] Space rotationSpace;
    [SerializeField] Vector3 axis = Vector3.up;

    // Update is called once per frame
    void Update()
    {

        float angle = angularSpeed * Time.deltaTime;
        transform.Rotate(axis, angle, rotationSpace);

    }

    void OnDrawGizmos()
    {

        Gizmos.color = Color.black;
        Vector3 center = transform.position;

        Vector3 dir = axis.normalized;

        if (rotationSpace == Space.Self)
        {

            dir = transform.TransformDirection(dir);

            Vector3 localup = transform.up;
            Vector3 localup2 = transform.TransformDirection(Vector3.up);

        }

        Vector3 a = center + axis.normalized;
        Vector3 b = center - axis.normalized; ;

        Gizmos.DrawLine(a, b);

    }
}
