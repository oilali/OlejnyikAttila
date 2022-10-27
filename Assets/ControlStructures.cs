
using UnityEngine;

public class ControlStructures : MonoBehaviour
{

    [SerializeField] int number;
    [SerializeField] string parity;
    [SerializeField] string domain;
    [SerializeField] string danger;
    [SerializeField] string dividableByThree;

    // Start is called before the first frame update
    void OnValidate()
    {

        bool isEven = number % 2 == 0; //páros e
        if (isEven)
        {
            parity = "Páros";
        }

        else
        {
            parity = "Páratlan";
        }

        //---

        if (number > 0) { domain = "POZITÍV"; } else if (number < 0) { domain = "NEGATÍV"; } else { domain = "NULLA"; }

        //---

        if (number < 10) { danger = "alacsony"; } else if (number < 35) { danger = "közepes"; } else if (number < 50) { danger = "magas"; } else { danger = "extrém"; }

        //---

        dividableByThree = number % 3 == 0 ? "OSZTHATÓ" : "NEM OSZTHATÓ";

        //---

        //Elágazások vége.

        //Ciklusok

    }

    private void Start()
    {
        /*
               int i = 1;
               int max = 100;



               while (i <= max)
               {

                   Debug.Log(i);

                   i++;
               }

               for (int j = 0; j < 5; j++)
               {

                   Debug.Log(j);

               }

               for (int j = 10; j >= 0; j--)
               {

                   Debug.Log(j);

               } */


        for (int i = 0; i < 100; i++)
        {

            if (i % 3 == 0 && i % 7 == 0)
            {
                Debug.Log(i);
            }


        }



    }

}
