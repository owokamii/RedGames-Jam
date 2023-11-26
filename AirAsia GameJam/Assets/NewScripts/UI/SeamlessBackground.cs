using UnityEngine;
using UnityEngine.UI;

public class SeamlessBackground : MonoBehaviour
{
    [SerializeField] private RawImage seamlessBackground;
    [SerializeField] private float x, y;

    void Update()
    {
        seamlessBackground.uvRect = new Rect(seamlessBackground.uvRect.position + new Vector2(x, y) * Time.deltaTime, seamlessBackground.uvRect.size);
    }
}
