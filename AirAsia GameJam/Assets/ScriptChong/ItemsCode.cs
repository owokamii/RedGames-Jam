//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ItemsCode : MonoBehaviour
//{
//    public static List<ItemsCode> PickedUpItems = new List<ItemsCode>();

//    private Collider2D myCollider;
//    public bool isPickedUp = false;
//    private void Start()
//    {
//        myCollider = GetComponent<Collider2D>();
//    }
//    private void Update()
//    {
//        if (Input.touchCount > 0)
//        {
//            Touch touch = Input.GetTouch(0);

//            if (touch.phase == TouchPhase.Began)
//            {
//                Vector3 touchPositionWorld = Camera.main.ScreenToWorldPoint(touch.position);
//                Vector2 touchPositionWorld2D = new Vector2(touchPositionWorld.x, touchPositionWorld.y);

//                if (myCollider == Physics2D.OverlapPoint(touchPositionWorld2D))
//                {
//                    PickUp();
//                    gameObject.SetActive(false);
//                }
//            }
//        }
//    }

//    private void OnMouseDown()
//    {
//        PickUp();
//        gameObject.SetActive(false);
//    }
//    void PickUp()
//    {
//        isPickedUp = true;
//        PickedUpItems.Add(this);
//    }
//}

