
using UnityEngine;

public class myFirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
        Debug.Log("Hello" + name);


        int myFirstVariable;

        myFirstVariable = 6;
        myFirstVariable = 9;

        Debug.Log(myFirstVariable);


        int integerNumber = 2;
        float floatingPointNumber = 2.3f; //kell a végére f
        string myString = "majom";
        bool myBoolean = true;


        int a = 3, b = 4, c = 5;
        int x, y, z;

        int summa = a + b;

        Debug.Log(summa);

        int diff = a + 30;

        Debug.Log(diff);

        diff -= 5;

        Debug.Log(diff);

        int product = a * 5;
        int ratio = product / 3;

        int modulo = 34 % a; //maradék

        var iii = "sok"; //így is lehet, de a típus marad

        int xxx = 3 + 2 * 4; // 11
        xxx = (3 + 2) * 4; //20

        string s1 = "Hello";
        string s2 = "World";

        string s3 = s1 + " " + s2;

        int i1 = 3, i2 = 7;
        string s4 = s1 + i1; //Hello3

        string s5 = s1 + i1 + i2;

        string s6 = i2.ToString();

        // string = i1 + i2 + s1; // itt elõbb összeadja a két integert

        // float ff1 = 3,5f;
        int ii1 = 4;

        // int ii2 = (int)ff1; //explicit castolás
        float ff2 = ii1;

        string numberText = "234";
        int ii3 = int.Parse(numberText);








    }

}
