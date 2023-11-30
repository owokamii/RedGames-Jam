using UnityEngine;

public class CursorPointer : MonoBehaviour
{
    /*public Texture2D cursor;
    public Texture2D cursorClicked;

    private Transform cursorPointer;
    private Vector3 displacement;

    private Draggable draggable;

    //[HideInInspector] public bool selected = false;

    private void Awake()
    {
        Vector2 cursorOffset = new Vector2(cursor.width / 2, cursor.height / 2);
        Cursor.SetCursor(cursor, cursorOffset, CursorMode.Auto);

        draggable = GetComponent<Draggable>();
        cursorPointer = GetComponent<Transform>();
        displacement = GetComponent<Vector3>();
    }

    *//*private void Update()
    {
        Vector2 cursorOffset = new Vector2(cursor.width / 2, cursor.height / 2);

        if (selected)
        {
            Debug.Log("item is selected");
            Cursor.SetCursor(cursorClicked, cursorOffset, CursorMode.Auto);
        }
        else
        {
            Cursor.SetCursor(cursor, cursorOffset, CursorMode.Auto);
        }
    }*/

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector2 cursorOffset = new Vector2(cursor.width / 2, cursor.height / 2);

        if (collision.gameObject.CompareTag("Item") || collision.gameObject.CompareTag("Cupboard"))
        {
            //Cursor.SetCursor(cursorClicked, cursorOffset, CursorMode.Auto);
            Debug.Log("items");
        }
        if (collision.gameObject.CompareTag("Untagged") || collision.gameObject.CompareTag("BigSurface") || collision.gameObject.CompareTag("SmallSurface"))
        {
            //Cursor.SetCursor(cursor, cursorOffset, CursorMode.Auto);
            Debug.Log("others");
        }
        Debug.Log("general");
    }*/

    /*private void OnMouseEnter()
    {
        Vector2 cursorOffset = new Vector2(cursor.width / 2, cursor.height / 2);

        Cursor.SetCursor(cursorClicked, cursorOffset, CursorMode.Auto);
    }

    private void OnMouseExit()
    {
        Vector2 cursorOffset = new Vector2(cursor.width / 2, cursor.height / 2);

        Cursor.SetCursor(cursor, cursorOffset, CursorMode.Auto);
    }*/
}
