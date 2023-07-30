using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class List : MonoBehaviour
{
    public GameObject textTemplate;
    public Transform content;

    public string[] fixedNames = new string[] { "hellohahaha", "2", "3", "4" };
    public string[] randomNames = new string[] { "Random1", "Random2", "Random3", "Random4", "Random5", "Random6" };
    private Dictionary<string, Text> nameTexts = new Dictionary<string, Text>();
    private HashSet<string> pickedItems = new HashSet<string>();
    void Awake()
    {
        ListUp();
    }

    void Start()
    {
        content.gameObject.SetActive(true);
    }

    void Update()
    {
        Draggable[] items = GameObject.FindObjectsOfType<Draggable>();
        foreach (Draggable item in Draggable.PickedUpItems)
        {
            UpdateList(item.gameObject.name);
        }
        //Draggable.PickedUpItems.Clear();
    }

    public void ListUp()
    {

        List<string> nameList = new List<string>(fixedNames);

        for (int i = 0; i < 3; i++)
        {
            string randomName = randomNames[Random.Range(0, randomNames.Length)];
            nameList.Add(randomName);
        }

        foreach (string name in nameList)
        {
            GameObject textElement = Instantiate(textTemplate, content);
            Text textComponent = textElement.GetComponent<Text>();
            if (textComponent != null)
            {
                textComponent.text = name;
                nameTexts[name] = textComponent;
            }
            textElement.SetActive(true);
        }
    }

    public void UpdateList(string pickedObjectName)
    {
        Debug.Log("UpdateList called with: " + pickedObjectName);

        if (nameTexts.ContainsKey(pickedObjectName))
        {
            Debug.Log("Name found in dictionary: " + pickedObjectName);
            Text textElement = nameTexts[pickedObjectName];
            textElement.color = Color.red;
            pickedItems.Add(pickedObjectName);
        }
        else
        {
            Debug.Log("Name not found in dictionary: " + pickedObjectName);
        }
    }
}
