
using UnityEngine;

public class EnemyRane : MonoBehaviour
{


    [SerializeField] float minRange, maxRange;
    [SerializeField] float rangeMultiplier;
    [SerializeField] float enemyDistance;

    [SerializeField] bool canHitEnemy;

    // Start is called before the first frame update
    void OnValidate()
    {

        canHitEnemy = (enemyDistance > minRange) &&
        (enemyDistance <= rangeMultiplier * maxRange);



    }

}
