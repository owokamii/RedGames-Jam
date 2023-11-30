
using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    public Texture2D cursor;
    public Texture2D cursorClicked;

    private Camera cam;

    private void Awake()
    {
        cam = GetComponent<Camera>();
    }

    void Start()
    {
        cam = GetComponent<Camera>();
        cam = Camera.main;
    }

    private void OnMouseDown()
    {
        Cursor.SetCursor(cursorClicked, Vector2.zero, CursorMode.Auto);
    }

    private void OnMouseUp()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }
}
