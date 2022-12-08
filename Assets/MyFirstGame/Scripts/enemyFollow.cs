using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed = 2;
    [SerializeField] float angularSpeed = 180;

    void Update()
    {

        Vector3 targetPosition = target.position; // ellenfél pozíció
        Vector3 selfPosition = transform.position; //saját pozíció 
        float stepDistance = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(selfPosition, targetPosition, stepDistance); //egymást követés (alap,cél,távolság)


        Vector3 direction = targetPosition - selfPosition;

        if (direction != Vector3.zero)
        {

            Quaternion targetRotation = Quaternion.LookRotation(direction);
            Quaternion currentRotation = transform.rotation;

            float maxStepInAngle = angularSpeed * Time.deltaTime;

            transform.rotation =

            Quaternion.RotateTowards(currentRotation, targetRotation, maxStepInAngle);

        }

    }

    /*
    void Update()
    {

        Vector3 targetPosition = target.position; // ellenfél pozíció
        Vector3 selfPosition = transform.position; //saját pozíció 

        Vector3 direction = targetPosition - selfPosition;

        float distance = direction.magnitude; //ez a két objektum közötti vektor hossza(magnitude)

        direction.Normalize();

        float stepDistance = speed * Time.deltaTime;

        transform.position += direction * stepDistance; //FPS független deltaTime

        if (stepDistance < distance) { stepDistance = distance; }


        if (direction != Vector3.zero)
        {

            transform.rotation = Quaternion.LookRotation(direction);

        }

    }*/
}
