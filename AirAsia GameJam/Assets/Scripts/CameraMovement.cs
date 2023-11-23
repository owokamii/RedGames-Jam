using UnityEngine;
using UnityEngine.UI;

public class CameraMovement : MonoBehaviour
{
    public Animator cameraMovement;
    public Button leftButton;
    public Button rightButton;

    public int counter = 0;

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
            cameraMovement.SetFloat("Index", counter);
        }
    }

    public void RightButton()
    {
        if(counter < 2)
        {
            counter++;
            cameraMovement.SetFloat("Index", counter);
        }
    }
}
