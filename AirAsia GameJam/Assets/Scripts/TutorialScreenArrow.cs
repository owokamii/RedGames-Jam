using UnityEngine;
using UnityEngine.UI;

public class TutorialScreenArrow : MonoBehaviour
{
    public Image tutorial1;
    public Image tutorial2;
    public Image tutorial3;
    public Image tutorial4;
    
    public Button leftButton;
    public Button rightButton;

    public int counter;

    private void Awake()
    {
        counter = 0;
    }

    /*private void Update()
    {
        if (counter == 0)
            leftButton.gameObject.SetActive(false);
        else
            leftButton.gameObject.SetActive(true);

        if(counter == 1)
            tutorial1.gameObject.SetActive(false);
            tutorial2.gameObject.SetActive(true);

        if(counter == 2)
           //tutorial2.gameObject.SetActive(false);
            //tutorial3.gameObject.SetActive(true);

        if (counter == 3)
            rightButton.gameObject.SetActive(false);
        else
            rightButton.gameObject.SetActive(true);
    }*/

    public void LeftButton()
    {
        if (counter > 0)
        {
            counter--;
        }
    }

    public void RightButton()
    {
        if (counter < 3)
        {
            counter++;
        }
    }
}
