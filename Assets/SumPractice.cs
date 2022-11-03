using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumPractice : MonoBehaviour
{
    [SerializeField, Min(1)] int number = 10;
    [SerializeField] int sum;
    // Start is called before the first frame update
    void OnValidate()
    {

        sum = 0;

        for (int i = 1; i <= number; i++)
        {

            sum += i;

        }

    }

}
