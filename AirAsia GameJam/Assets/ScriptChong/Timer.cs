using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Timer UI references:")]
    [SerializeField] private Image uiFillImage;
    [SerializeField] private TMP_Text uiText;
    [SerializeField] private TMP_Text itemCountText;
    [SerializeField] private TMP_Text totalCountText;
    [SerializeField] private TMP_Text totalCountText2;
    [SerializeField] private TMP_Text totalCountText3;
    [SerializeField] private TMP_Text totalCountText4;

    public int Duration { get; private set; }

    public int remainingDuration;
    public GameObject listUI;
    public GameObject ListButton;
    public GameObject CutScene1;
    public GameObject CutScene2;
    public GameObject CutScene3;
    public GameObject CutScene4;

    int remainingTime;
    bool counted = false;

    private void Awake()
    {
        ResetTimer();
    }

    //public float GetRemainingDuration()
    //{
    //    return remainingDuration;
    //}

    private void ResetTimer()
    {
        uiText.text = "00:00";
        uiFillImage.fillAmount = 0f;

        //Duration = remainingDuration = 0;
        Debug.Log("reset timer");
    }

    public Timer SetDuration(int seconds)
    {
        Duration = remainingDuration = seconds;
        return this;
    }

    public void Begin()
    {
        Debug.Log("Begin");
        StopAllCoroutines();
        StartCoroutine(UpdateTimer());
    }

    private void Update()
    {
        //Debug.Log(Retry.done);
        if (Retry.done)
        {
            if(!counted)
                remainingTime = remainingDuration;
                counted = true;
            remainingDuration = 0;
            Debug.Log("remainin time" + remainingTime);
            Debug.Log("remaining duration" + remainingDuration);
            Debug.Log("list count" + List.count);
        }
        itemCountText.text = Draggable.itemCount + "/15 ";
        totalCountText.text = List.count + "/15 ";
        totalCountText2.text = List.count + "/15 ";
        totalCountText3.text = List.count + "/15 ";
        totalCountText4.text = List.count + "/15 ";
    }
    private IEnumerator UpdateTimer()
    {
        while (remainingDuration > 0)
        {
            //Debug.Log("decreasing time");
            //Debug.Log(remainingDuration);
            UpdateUI(remainingDuration);
            //Debug.Log("Timer");
            remainingDuration--;
            yield return new WaitForSeconds(1f);
            //listUI.SetActive(true);
        }
        listUI.SetActive(true);
        ListButton.SetActive(false);
        //Debug.Log("timer ended");
        End();

        if (remainingDuration <= 0)
        {
            yield return new WaitForSeconds(1f);
            listUI.SetActive(false);
            FindObjectOfType<AudioManager>().StopPlaying("BGM");
            winOrLose();
        }
    }

    public void winOrLose()
    {
        if(remainingTime <= 0)
        {
            FindObjectOfType<AudioManager>().Play("Lose");
            Time.timeScale = 0f;
            CutScene3.SetActive(true);
        }
        else
        {
            if (List.count >= 0 && List.count <= 5)
            {
                FindObjectOfType<AudioManager>().Play("Lose");
                Time.timeScale = 0f;
                CutScene4.SetActive(true);
            }
            else if (List.count >= 6 && List.count <= 14)
            {
                FindObjectOfType<AudioManager>().Play("Win");
                Time.timeScale = 0f;
                CutScene2.SetActive(true);
            }
            else
            //if (List.count == 15)
            {
                FindObjectOfType<AudioManager>().Play("Win");
                Time.timeScale = 0f;
                CutScene1.SetActive(true);
            }
        }

        /*if (List.count == 15)
        {
            FindObjectOfType<AudioManager>().Play("Win");
            Time.timeScale = 0f;
            CutScene1.SetActive(true);
        }
        else if (remainingDuration <= 0)
        {
            if (List.count >= 10)
            {
                FindObjectOfType<AudioManager>().Play("Win");
                Time.timeScale = 0f;
                CutScene2.SetActive(true);
            }
            else if (List.count >= 4)
            {
                FindObjectOfType<AudioManager>().Play("Lose");
                Time.timeScale = 0f;
                CutScene3.SetActive(true);
            }
            else if (List.count < 4)
            {
                FindObjectOfType<AudioManager>().Play("Lose");
                Time.timeScale = 0f;
                CutScene4.SetActive(true);
            }
        }*/

    }
    private void UpdateUI(int seconds)
    {
        uiText.text = string.Format("{0:D2}:{1:D2}", seconds / 60, seconds % 60);
        uiFillImage.fillAmount = Mathf.InverseLerp(0, Duration, seconds);
    }

    public void End()
    {
        ResetTimer();
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }
}