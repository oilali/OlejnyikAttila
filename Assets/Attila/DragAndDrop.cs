
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{

    [SerializeField] SpriteRenderer highlight;

    private void OnMouseEnter()
    {
        if (highlight != null)
        {
            highlight.enabled = true;
        }
    }

    private void OnMouseExit()
    {
        if (highlight != null)
        {
            highlight.enabled = false;
        }
    }

    Vector2 cardStartPosition;
    Vector2 mouseStartPosition;

    private void OnMouseDown()
    {
        mouseStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cardStartPosition = transform.position;

    }

    private void OnMouseDrag()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //konvert�l�s pixerlb�l vektorr�.

        Vector2 offsetVector = mousePosition - mouseStartPosition;

        transform.position = offsetVector + cardStartPosition;

    }

    private void OnMouseUp()
    {

        /*findobjecttel meg lehet n�zni, melyik a legk�zelebbi �s oda fog snappelni.*/

    }

}
