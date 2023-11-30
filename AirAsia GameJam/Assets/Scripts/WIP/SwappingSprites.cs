using UnityEngine;

public class SwappingSprites : MonoBehaviour
{

    //private SpriteRenderer currentSprite;
    //public Sprite[] itemSprite;

    public GameObject[] itemTypes;
    public Rigidbody2D[] itemGravity;
        
    // 0 default
    // 1 folded

    private void Awake()
    {
        //currentSprite = GetComponent<SpriteRenderer>();
        //item = GetComponentInChildren<GameObject>();
    }

    // swapping item sprites
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // touches big surfaces
        if(collision.gameObject.CompareTag("BigSurface"))
        {
            //currentSprite.sprite = itemSprite[0];
            // change item collider to 0
            //gameObject.SetActive(false);
            itemTypes[0].SetActive(true);
            itemTypes[1].SetActive(false);
            itemGravity[0].gravityScale = 1;
            itemGravity[1].gravityScale = 0;
        }

        // touches small surfaces
        if(collision.gameObject.CompareTag("SmallSurface"))
        {
            //currentSprite.sprite = itemSprite[1];
            // change item collider to 1
            //gameObject.SetActive(true);
            itemTypes[0].SetActive(false);
            itemTypes[1].SetActive(true);
            itemGravity[0].gravityScale = 0;
            itemGravity[1].gravityScale = 1;
        }
    }
}
