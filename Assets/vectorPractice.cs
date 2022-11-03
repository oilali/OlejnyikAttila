using UnityEngine;

public class vectorPractice : MonoBehaviour
{

    [SerializeField] Vector2 vField2; //2D vektor
    [SerializeField] Vector3 vField3; //3D vektor

    // Start is called before the first frame update
    void OnValidate()
    {

        Vector2 vector2 = new Vector2(20, 1.5f);
        Vector3 vector3 = new Vector3(20, 10, 5);

        Vector3 zeroVector = Vector3.zero; //0,0,0
        Vector3 upVector = Vector3.up; //0,1,0
        Vector3 leftVector = Vector3.left; //-1,0,0

        float v3y = vector3.y; //egy adott érték lekérdezése az Y tenelyen

        vector3.z = 0;

        //----

        Vector3 vec1 = new Vector3(1, 2, 3);
        Vector3 vec2 = new Vector3(4, 5, 6);

        Vector3 summaVec = vec1 + vec2;
        Vector3 differenceVec = vec1 - vec2;
        Vector3 productVec = vec1 * 2;


    }

}
