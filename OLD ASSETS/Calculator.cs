
using UnityEngine;

public class Calculator : MonoBehaviour
{

    [SerializeField] float firstValue, secondValue;


    [SerializeField] float summa;
    [SerializeField] float difference;
    [SerializeField] float ratio;
    [SerializeField] float product;
    [SerializeField] float modulo;


    // Start is called before the first frame update
    void OnValidate()
    {

        summa = firstValue + secondValue;
        difference = firstValue - secondValue;
        product = firstValue * secondValue;
        ratio = firstValue / secondValue;
        modulo = firstValue % secondValue;



    }


}
