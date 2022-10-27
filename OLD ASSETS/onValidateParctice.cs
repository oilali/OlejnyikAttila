
using UnityEngine;

public class onValidateParctice : MonoBehaviour
{


    [SerializeField] int intSetting;
    [SerializeField] string strSetting;
    [SerializeField] float floatSetting;
    [SerializeField] bool boolSetting;
    [SerializeField] int startAmmo = 20;

    /*Ez az Uniti felületén állítható lértéket ad vissza*/

    int fieldVariable = 55; //osztályszintûváltozó

    [Space] //a mezõk között helyet hagy ki.


    [SerializeField] float n1, n2;
    [SerializeField] float sum;


    //onValidate nem fut le, kifejezetten a fejlesztést segíti.
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
