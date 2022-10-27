using UnityEngine;

public class BoolPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool b = true;
        b = false;

        int i1 = 23;
        int i2 = 30;

        bool areTheIsEqual = i1 == i2; //Egy bool-t ad vissza, ha egyenlõ true.

        Debug.Log(areTheIsEqual);

        string s1 = "AAA";
        string s2 = "AAA";

        bool areTheStringsEqual = s1 == s2;


        int i3 = 4, i4 = 78;
        bool areTheInsNotEqual = i3 != i4;

        float ddd = (float)3 / 2; //csak így lesz float-

        bool isTheFirstHigher = i3 > i4;
        bool isTheFirstSmaller = i3 < i4;

        // ugyanez mûködik <= - vel is.

        bool isGrounded = true; // a földön állunk e?
        int AirJump = 3; //Hányat lehet ugrani még?


        bool canJump = isGrounded || (AirJump > 0); //vagy

        int ammo = 23;
        float timeLeftSinceLastShoot = 3.4f;

        float @cooldown = 1;

        bool canShoot = (ammo > 0) && (timeLeftSinceLastShoot >= @cooldown); //és

        bool canNotShoot = !canShoot; //negálás

        bool xor = true ^ true; // ez false lesz




    }


}
