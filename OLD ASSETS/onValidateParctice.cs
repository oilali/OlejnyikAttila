
using UnityEngine;

public class onValidateParctice : MonoBehaviour
{


    [SerializeField] int intSetting;
    [SerializeField] string strSetting;
    [SerializeField] float floatSetting;
    [SerializeField] bool boolSetting;
    [SerializeField] int startAmmo = 20;

    /*Ez az Uniti fel�let�n �ll�that� l�rt�ket ad vissza*/

    int fieldVariable = 55; //oszt�lyszint�v�ltoz�

    [Space] //a mez�k k�z�tt helyet hagy ki.


    [SerializeField] float n1, n2;
    [SerializeField] float sum;


    //onValidate nem fut le, kifejezetten a fejleszt�st seg�ti.
    void OnValidate()
    {

        sum = n1 + n2;


    }

    // Start is called before the first frame update
    void Start()
    {

        int localVariable = 66;
        int summa = localVariable + fieldVariable + intSetting;

        Debug.Log(summa);

    }


}
