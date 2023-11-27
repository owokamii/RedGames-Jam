using UnityEngine;
using UnityEngine.UI;

public class CallList : MonoBehaviour
{
    public GameObject listUI;
    private Collider2D myCollider;
    public Button ListButton;

    private void Start()
    {
        myCollider = GetComponent<Collider2D>();
    }
    private void Update()
    {
        ListButton.onClick.AddListener(ListShow);

    }

    void ListShow()
    {
        listUI.SetActive(true);
        gameObject.SetActive(false);
    }
}