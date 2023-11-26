using UnityEngine;
using UnityEngine.UI;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Animator mainCameraAnimator;
    public Button leftButton;
    public Button rightButton;

    private int counter = 0;

    private void Awake()
    {
        mainCameraAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(counter == 0)
            leftButton.gameObject.SetActive(false);
        else
            leftButton.gameObject.SetActive(true);
        if(counter == 2)
            rightButton.gameObject.SetActive(false);
        else
            rightButton.gameObject.SetActive(true);
    }

    public void LeftButton()
    {
        if(counter  > 0)
        {
            counter--;
            mainCameraAnimator.SetFloat("Index", counter);
        }
    }

    public void RightButton()
    {
        if(counter < 2)
        {
            counter++;
            mainCameraAnimator.SetFloat("Index", counter);
        }
    }
}
