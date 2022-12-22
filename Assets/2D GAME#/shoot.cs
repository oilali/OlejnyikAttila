using UnityEngine;

enum ShootingPattern
{

    First,
    Sequence,
    Random,
    PingPong

}

public class shoot : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform startPoint;
    //[SerializeField] GameObject projectile;
    [SerializeField] GameObject[] projectiles;
    [SerializeField] KeyCode key = KeyCode.X;
    [SerializeField] ShootingPattern pattern;

    int index = 0;

    void Update()
    {

        if (Input.GetKeyDown(key))
        {

            int i;
            if (pattern == ShootingPattern.First) { i = 0; }
            else if (pattern == ShootingPattern.Sequence) { i = index % projectiles.Length; }
            else if (pattern == ShootingPattern.Random) { i = Random.Range(0, projectiles.Length); }
            else { i = 0; }

            GameObject newProjectile = Instantiate(projectiles[index]);
            newProjectile.transform.position = startPoint.position;

            Vector2 velocity = speed * transform.right;

            projectile p = newProjectile.GetComponent<projectile>();

            p.SetVelocity(velocity);

            index++;
            if (index >= projectiles.Length)
            {

                index = 0;

            }
        }

    }



}
