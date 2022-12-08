
using UnityEngine;

class Collector : MonoBehaviour
{

    int collectedValue = 0;
    void OnTriggerEnter(Collider other)
    {

        Collectable collectable = other.gameObject.GetComponent<Collectable>();

        if (collectable != null)
        {

            collectedValue += collectable.GetValue();

            Debug.Log("Collected" + collectable.GetValue());
            collectable.Teleport();
        }

    }

}
