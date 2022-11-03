
using UnityEngine;

public class MinMax : MonoBehaviour
{

    [SerializeField] int a, b;
    [SerializeField] int min, max;

    // Start is called before the first frame update
    void OnValidate()
    {

        if (a < b)
        {
            min = a;
        }
        else
        {
            min = b;
        }

        max = a > b ? a : b;

        min = Mathf.Min(a, b);
        min = Mathf.Max(a, b);


        min = Minimum(a, b);
        max = Maximum(a, b);


    }

    //void = eljárás, nincs visszatérési értéke

    int Minimum(int p1, int p2)
    {

        int resultP1P2min = p1 > p2 ? p2 : p1;

        return resultP1P2min;

    }


    int Maximum(int p1, int p2)
    {

        if (p1 > p2) { return p1; }
        else { return p2; }


    }


}
