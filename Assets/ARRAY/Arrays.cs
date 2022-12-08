using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    [SerializeField] int[] intArray;
    [SerializeField] int maxAmount;
    [SerializeField] List<int> intList;
    [SerializeField] List<int> intList2;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < intArray.Length; i++)
        {

            int element = intArray[i];
            Debug.Log(element);

        }

        foreach (int element in intArray)
        {

            Debug.Log(element);

        }

        for (int i = intArray.Length - 1; i >= 0; i--)
        {

            int element = intArray[i];
            Debug.Log(element);

        }


        string[] stringArray = new string[maxAmount];

        for (int i = 1; i < maxAmount; i++)
        {

            string actual = (i * i).ToString();

            stringArray[i] = actual;

            Debug.Log(i);

        }

        int[] fibonacciArray = new int[maxAmount];

        for (int i = 1; i < maxAmount; i++)
        {

            fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];


        }


        /// --- Lista
        /// 
        List<string> stringlist = new List<string>();

        for (int i = 0; i < 10; i++)
        {

            int num = (i + 1) * (i + 1);

            stringlist.Add(num.ToString());

        }

        bool succesfullRemove = stringlist.Remove("50");
        stringlist.RemoveAt(3);

        stringlist.Clear();


        //List<int> intList2 = new List<int>();

        for (int i = 0; i < 100; i++)
        {

            int random = Random.Range(1, 101);
            intList2.Add(random);

        }

        for (int i = intList2.Count - 1; i >= 0; i--)
        {

            int actual2 = intList2[i];

            if (actual2 % 2 == 0)
            {

                intList2.Remove(i);

            }

            // Debug.Log("aktuális" + actual2);

        }

        intList2.Sort();
        stringlist.Insert(5, "Alma");
        bool c = stringlist.Contains("körte");
        int KorteIndex = stringlist.IndexOf("Körte");

        List<int> intlist5 = new List<int>(intArray);
        int[] intArray5 = intlist5.ToArray();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
