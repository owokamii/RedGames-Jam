/*using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class Timer3 : MonoBehaviour
{
    [Header("Timer UI references:")]
    [SerializeField] private Image uiFillImage;
    [SerializeField] private TMP_Text uiText;

    public int Duration { get; private set; }

    private int remainingDuration;

    private void Awake()
    {
        ResetTimer();
    }

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

    private IEnumerator UpdateTimer()
    {
        while (remainingDuration > 0)
        {
            Debug.Log("decreasing time");
            Debug.Log(remainingDuration);
            UpdateUI(remainingDuration);
            Debug.Log("Timer");
            remainingDuration--;
            yield return new WaitForSeconds(1f);
        }
        Debug.Log("timer ended");
        End();
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
public class Retry : MonoBehaviour
{
    public Button reloadButton;

    void Start()
    {
        reloadButton.onClick.AddListener(ReloadScene);
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }*/