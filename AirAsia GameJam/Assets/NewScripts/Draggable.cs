using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    public string[] names = new string[3];
    public GameObject item;

    public static int itemCount;
    public static List<string> PickedUpItems = new List<string>();
    private Collider2D myCollider;
    public bool isPickedUp = false;
    Vector3 mousePositionOffset;
    public bool isHolding = false;
    public BoxCollider2D itemCollider;

    private void Start()
    {
        myCollider = GetComponent<Collider2D>();
        itemCount = 0;
    }


    private Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        if (!(PauseMenu.GameIsPaused))
        {
            itemCollider.enabled = false;
            isHolding = true;
            mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
            //myCollider.isTrigger = true;
            FindObjectOfType<AudioManager>().Play("Pick");
        }
        else
        {
            isHolding = false;
        }
    }

    private void OnMouseUp()
    {
        //myCollider.isTrigger = false;
        isHolding = false;
        itemCollider.enabled = true;
    }

    private void OnMouseDrag()
    {
        if (!(PauseMenu.GameIsPaused))
        {
            itemCollider.enabled = false;
            isHolding = true;
            transform.position = GetMouseWorldPosition() + mousePositionOffset;
        }
        else
        {
            isHolding = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(isHolding)
            if (collider.gameObject.name == "Luggage" && itemCount <= 14)
            {
                FindObjectOfType<AudioManager>().Play("IntoSuitcase");
                PickUp();
                itemCount++;
                gameObject.SetActive(false);
            }
    }

    public void PickUp()
    {
        foreach (string name in names)
        {
            PickedUpItems.Add(name);
        }
        //isPickedUp = true;
        //PickedUpItems.Add(this);
    }

    public static void ResetPickedUpItems()
    {
        PickedUpItems.Clear();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            FindObjectOfType<AudioManager>().Play("Drop");
        }
    }
}