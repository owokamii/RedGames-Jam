using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHiding : MonoBehaviour
{
    public GameObject UIObject;
    public GameObject UICall;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && UIObject.activeSelf)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            BoxCollider2D boxCollider = UIObject.GetComponent<BoxCollider2D>();

            if (boxCollider != null)
            {
                if (!boxCollider.OverlapPoint(mousePosition))
                {
                        UIObject.SetActive(false);
                        UICall.SetActive(true);
                }
            }
            else
            {
                Debug.LogError("UIObject does not have a BoxCollider2D!");
            }
        }
    }
}

