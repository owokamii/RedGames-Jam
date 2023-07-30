using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    public static List<Draggable> PickedUpItems = new List<Draggable>();
    private Collider2D myCollider;
    public bool isPickedUp = false;
    Vector3 mousePositionOffset;

    private Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPosition() + mousePositionOffset;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "suitcase")
        {
            PickUp();
            gameObject.SetActive(false);
        }
    }

    public void PickUp()
    {
        isPickedUp = true;
        PickedUpItems.Add(this);
    }
}
