using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class List : MonoBehaviour
{
    public static int count;
    public GameObject textTemplate;
    public GameObject text;
    public Transform content;

    //fix array
    public string[] cloth1 = new string[] { "summer clothes", "clothes to wear when warm", "breathable clothes" };
    public string[] cloth2 = new string[] { "winter clothes", "warm clothes", "warm straight jacket" };
    public string[] cloth3 = new string[] { "casual clothes", "comfy clothes", "everywhere wear" };
    public string[] cloth4 = new string[] { "formal clothes", "stuffy clothes", "wage slave wear" };
    public string[] tower1 = new string[] { "bath towel", "opposite of face towel", "dewetting cloth" };
    public string[] tower2 = new string[] { "face towel", "opposite of bath towel", "opposite of butt towel" };
    public string[] sock1 = new string[] { "thick socks", "feet warmers", "extra extra uncomfortable when wet" };
    public string[] sock2 = new string[] { "thin socks", "short stockings", "extra uncomfortable when wet" };
    public string[] shoes1 = new string[] { "casual shoes", "wear something on feet preferably comfortable", "casual feet protec toes" };
    public string[] shoes2 = new string[] { "sports shoes", "shoes for sports", "gotta go fast" };
    public string[] shoes3 = new string[] { "formal shoes", "uncomfortable shoes", "worker feet protection" };
    public string[] shoes4 = new string[] { "slippers", "shoe that is more exposed", "the thing your mom hits you with" };
    public string[] toilet = new string[] { "toiletries bag", "cleaning tools for humans", "bathroom components" };
    public string[] Underwear = new string[] { "underwear", "lesser shorts", "DON’T GO COMMANDO" };

    //not fix array
    public string[] Swimsuit = new string[] { "swim suit", "water repellent wear", "totally not scuba gear" };
    public string[] Laptop = new string[] { "laptop", "handheld PC", "folding thinking machine" };
    public string[] LaptopCharger = new string[] { "laptop charger", "electric transporter", "thinking machine replenisher" };
    public string[] PlayingCards = new string[] { "playing cards", "gambler set", "start of gambling addiction" };
    public string[] Gameconsole = new string[] { "game console", "smol game thing", "handheld fun" };
    public string[] Gamecontroller = new string[] { "game controller", "used to play games with", "fun controller" };
    public string[] Plushie = new string[] { "plushie", "smol friend", "cherished companion" };
    public string[] Pillow = new string[] { "pillow", "sleep enabler", "marshmallow" };
    public string[] Perfume = new string[] { "perfume", "nose pleaser", "MEN ACTRACTOR" };
    public string[] Scarf = new string[] { "scarf", "neck warmer", "neck rope" };
    public string[] Sunscreen = new string[] { "sunscreen", "son-blocked", "ray reflector paste" };
    public string[] Medicine = new string[] { "medicine", "illness destroyer", "The good beans" };
    public string[] Backpack = new string[] { "backpack", "stuff holder", "fabric container" };
    public string[] Waterbottle = new string[] { "water bottle", "dihydrogen monoxide container", "H20" };
    public string[] TravelPillow = new string[] { "travel pillow", "neck rester", "THE U" };
    public string[] Sunglasses = new string[] { "sunglasses", "terminator eye wear", "black glass with sticks" };
    public string[] Camera = new string[] { "camera", "memory maker", "scene constructor" };
    public string[] Headphones = new string[] { "headphones", "ear pleasers", "music ear things" };


    private Dictionary<string, Text> nameTexts = new Dictionary<string, Text>();
    private HashSet<string> pickedItems = new HashSet<string>();
    void Awake()
    {
        ListUp();
    }

    void Start()
    {
        content.gameObject.SetActive(true);
        count = 0;
    }

    void Update()
    {
        Draggable[] items = GameObject.FindObjectsOfType<Draggable>();
        foreach (string item in Draggable.PickedUpItems)
        {
            UpdateList(item);
        }
        //Draggable.PickedUpItems.Clear();
    }


    public void ListUp()
    {
        List<string[]> mainArrays = new List<string[]> { cloth1, cloth2, cloth3, cloth4 };
        List<string[]> mainArrays2 = new List<string[]> { tower1, tower2 };
        List<string[]> mainArrays3 = new List<string[]> { sock1, sock2 };
        List<string[]> mainArrays4 = new List<string[]> { shoes1, shoes2, shoes3, shoes4 };
        List<string[]> mainArrays5 = new List<string[]> { toilet };
        List<string[]> mainArrays6 = new List<string[]> { Underwear };
        List<string[]> mainArrays9 = new List<string[]> { Swimsuit, Laptop, LaptopCharger, PlayingCards, Gameconsole, Gamecontroller, Plushie, Pillow, Perfume, Scarf, Sunscreen, Medicine, Backpack, Waterbottle, TravelPillow, Sunglasses, Camera, Headphones };
        List<string> selectedItems = new List<string>();
        List<string> nameList = new List<string>();

        for (int i = 0; i < 2; i++)
        {
            int randomMainIndex = Random.Range(0, mainArrays.Count);
            string[] selectedMainArray = mainArrays[randomMainIndex];
            mainArrays.RemoveAt(randomMainIndex);

            string selectedItem = selectedMainArray[Random.Range(0, selectedMainArray.Length)];
            selectedItems.Add(selectedItem);
        }

        for (int i = 0; i < 1; i++)
        {
            int randomMainIndex = Random.Range(0, mainArrays2.Count);
            string[] selectedMainArray = mainArrays2[randomMainIndex];
            mainArrays2.RemoveAt(randomMainIndex);

            string selectedItem = selectedMainArray[Random.Range(0, selectedMainArray.Length)];
            selectedItems.Add(selectedItem);
        }

        for (int i = 0; i < 1; i++)
        {
            int randomMainIndex = Random.Range(0, mainArrays3.Count);
            string[] selectedMainArray = mainArrays3[randomMainIndex];
            mainArrays3.RemoveAt(randomMainIndex);

            string selectedItem = selectedMainArray[Random.Range(0, selectedMainArray.Length)];
            selectedItems.Add(selectedItem);
        }

        for (int i = 0; i < 2; i++)
        {
            int randomMainIndex = Random.Range(0, mainArrays4.Count);
            string[] selectedMainArray = mainArrays4[randomMainIndex];
            mainArrays4.RemoveAt(randomMainIndex);

            string selectedItem = selectedMainArray[Random.Range(0, selectedMainArray.Length)];
            selectedItems.Add(selectedItem);
        }

        for (int i = 0; i < 1; i++)
        {
            int randomMainIndex = Random.Range(0, mainArrays5.Count);
            string[] selectedMainArray = mainArrays5[randomMainIndex];
            mainArrays5.RemoveAt(randomMainIndex);

            string selectedItem = selectedMainArray[Random.Range(0, selectedMainArray.Length)];
            selectedItems.Add(selectedItem);
        }

        for (int i = 0; i < 1; i++)
        {
            int randomMainIndex = Random.Range(0, mainArrays6.Count);
            string[] selectedMainArray = mainArrays6[randomMainIndex];
            mainArrays6.RemoveAt(randomMainIndex);

            string selectedItem = selectedMainArray[Random.Range(0, selectedMainArray.Length)];
            selectedItems.Add(selectedItem);
        }

        for (int i = 0; i < 7; i++)
        {
            int randomMainIndex = Random.Range(0, mainArrays9.Count);
            string[] selectedMainArray = mainArrays9[randomMainIndex];
            mainArrays9.RemoveAt(randomMainIndex);

            string selectedItem = selectedMainArray[Random.Range(0, selectedMainArray.Length)];
            selectedItems.Add(selectedItem);
        }

        nameList.AddRange(selectedItems);

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

        if (nameTexts.ContainsKey(pickedObjectName) && !pickedItems.Contains(pickedObjectName))
        {
            count++;
            //Debug.Log("Name found in dictionary: " + pickedObjectName);
            Text textElement = nameTexts[pickedObjectName];
            textElement.color = Color.red;
            pickedItems.Add(pickedObjectName);
            Debug.Log("Count: " + count);
        }
        //if (nameTexts.ContainsKey(pickedObjectName))
        //{
        //    Debug.Log("Name found in dictionary: " + pickedObjectName);
        //    Text textElement = nameTexts[pickedObjectName];
        //    textElement.color = Color.red;
        //    pickedItems.Add(pickedObjectName);
        //}
        else
        {
            //Debug.Log("Name not found in dictionary: " + pickedObjectName);
        }
    }
}
