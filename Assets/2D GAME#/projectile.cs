using System.Collections;
using UnityEngine;

public class projectile : MonoBehaviour
{
    [SerializeField] float lifeTime = 3;

    Vector2 velocity;

    //float startTime;

    private void Start()
    {
        // startTime = Time.time;

        StartCoroutine(DestroyCoroutine());
    }

    IEnumerator DestroyCoroutine()

    {
        yield return new WaitForSeconds(lifeTime);
        yield return null; //várakozás egy frame-t
        Destroy(gameObject);

    }

    public void SetVelocity(Vector2 vel)
    {

        velocity = vel;

    }

    void Update()
    {

        /*  transform.position += (Vector3)velocity * Time.deltaTime;

          float age = Time.time - startTime;

          if (age > lifeTime)
          {

              Destroy(gameObject);

          }*/
    }

}
