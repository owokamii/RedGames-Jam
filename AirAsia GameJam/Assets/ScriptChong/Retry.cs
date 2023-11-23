using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Retry : MonoBehaviour
{
    public static bool done;
    public Button DoneButton;
    public GameObject listUI;

    void Start()
    {
        done = false;
    }

    private void Update()
    {
        DoneButton.onClick.AddListener(ReloadScene);

    }

    void ReloadScene()
    {
        done = true;
    }
}
