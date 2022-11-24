using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemageBox : MonoBehaviour
{

    [SerializeField] int demage = 10;
    [SerializeField] bool instaKill = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        HealthObject v_healtObject = collision.gameObject.GetComponent<HealthObject>();

        if (v_healtObject != null)
        {

            if (instaKill)
            {

                v_healtObject.Kill();
            }
            else
            {

                v_healtObject.Damage(demage);

            }
        }
    }
}
