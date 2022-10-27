
using UnityEngine;

public class MethodParctice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyOwnMethod(3, "majom");
        Debug.Log("START");
        MyOwnMethod(5, "alma");
        Debug.Log("START");
        Debug.Log("----");

        int a = Power(5, 3);
        int b = Power(8, 8);
        int c = Power(2, 10);

        Debug.Log($"{a} {b} {c}");
    }

    //void ->nincs kimenete

    void MyOwnMethod(int a, string b)

    {

        while (a <= 20)
        {

            Debug.Log(b + a);

            a++;
        }
    }

    int Power(int baseNumber, int exponent)
    {

        int a = 1;
        for (int i = 0; i < exponent; i++)
        {

            a *= baseNumber;


        }
        return a;

    }

}
