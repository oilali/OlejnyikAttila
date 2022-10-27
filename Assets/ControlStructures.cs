
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

        bool isEven = number % 2 == 0; //p�ros e
        if (isEven)
        {
            parity = "P�ros";
        }

        else
        {
            parity = "P�ratlan";
        }

        //---

        if (number > 0) { domain = "POZIT�V"; } else if (number < 0) { domain = "NEGAT�V"; } else { domain = "NULLA"; }

        //---

        if (number < 10) { danger = "alacsony"; } else if (number < 35) { danger = "k�zepes"; } else if (number < 50) { danger = "magas"; } else { danger = "extr�m"; }

        //---

        dividableByThree = number % 3 == 0 ? "OSZTHAT�" : "NEM OSZTHAT�";

        //---

        //El�gaz�sok v�ge.

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
