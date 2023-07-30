using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallList : MonoBehaviour
{
    //public GameObject listUI;

    //private void OnMouseDown()
    //{
    //    listUI.SetActive(true);
    //}
    public GameObject listUI;
    private Collider2D myCollider;

    private void Start()
    {
        myCollider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Vector3 touchPositionWorld = Camera.main.ScreenToWorldPoint(touch.position);
                Vector2 touchPositionWorld2D = new Vector2(touchPositionWorld.x, touchPositionWorld.y);

                if (myCollider == Physics2D.OverlapPoint(touchPositionWorld2D))
                {
                    if (listUI != null)
                    {
                        listUI.SetActive(true);
                        gameObject.SetActive(false);
                    }
                }
            }
        }
    }

    private void OnMouseDown()
    {
        if (listUI != null)
        {
            listUI.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
