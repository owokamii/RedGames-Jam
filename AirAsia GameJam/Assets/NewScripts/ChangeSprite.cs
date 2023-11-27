using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public Sprite newSprite;
    public Timer timer;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (timer.remainingDuration <=0)
        {
            spriteRenderer.sprite = newSprite;
        }
    }
}