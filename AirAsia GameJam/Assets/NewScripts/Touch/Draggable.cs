using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    public float itemMass;
    public static List<string> PickedUpItems = new List<string>();
    public string[] itemDescriptions = new string[3];

    public static int itemCount;

    private Vector3 mousePositionOffset;
    private bool isHolding = false;
    private BoxCollider2D bottomCollider;
    private PolygonCollider2D itemCollider;
    private Rigidbody2D rigidBody;

    private void Awake()
    {
        bottomCollider = GetComponent<BoxCollider2D>();
        itemCollider = GetComponent<PolygonCollider2D>();
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.mass = itemMass;
        itemCount = 0;
    }

    private Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // when mouse button is clicked
    private void OnMouseDown()
    {
        if (!(PauseMenu.GameIsPaused))
        {
            if(!gameObject.CompareTag("Hidden"))
            {
                bottomCollider.enabled = false;
                isHolding = true;
                mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
                FindObjectOfType<AudioManager>().Play("Pick");
            }
        }
        else
        {
            isHolding = false;
        }
    }

    // when mouse button is hold
    private void OnMouseDrag()
    {
        if (!(PauseMenu.GameIsPaused))
        {
            if (!gameObject.CompareTag("Hidden"))
            {
                bottomCollider.enabled = false;
                isHolding = true;
                transform.position = GetMouseWorldPosition() + mousePositionOffset;
            }
        }
        else
        {
            isHolding = false;
        }
    }

    // when mouse button is let go
    private void OnMouseUp()
    {
        isHolding = false;
        bottomCollider.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(isHolding)
        {
            if (collider.gameObject.name == "Luggage" && itemCount <= 14)
            {
                FindObjectOfType<AudioManager>().Play("IntoSuitcase");
                PickUp();
                itemCount++;
                gameObject.SetActive(false);
            }
        }
        else
        {
            if(collider.gameObject.CompareTag("Cupboard"))
            {
                itemCollider.enabled = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        itemCollider.enabled = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<AudioManager>().Play("Drop");

        /*if (collision.gameObject.CompareTag("Ground"))
        {
            FindObjectOfType<AudioManager>().Play("Drop");
        }*/
    }

    public void PickUp()
    {
        foreach (string name in itemDescriptions)
        {
            PickedUpItems.Add(name);
        }
    }

    public static void ResetPickedUpItems()
    {
        PickedUpItems.Clear();
    }
}