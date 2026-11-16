using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private bool wahrheitswert; //default-Wert ist: false

    private int zahl = 5; //deafault-Wert ist: 0

    public float kommazahl = 3.14f; //default-Wert ist: 0.0f

    public string text = "meinText"; //default-Wert ist: ""

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        zahl = AddNumbers(7, 29);
        DisplayText("meinText");

    }

    // Update is called once per frame
    void Update()
    {
 
    }

     int AddNumbers(int a, int b)
    {
        int ergebnis = a + b;
        Debug.Log("AddNumbers-Ergebnis:" + ergebnis);

        return ergebnis;
    }

    void DisplayText(string meinText)
    {
        Debug.Log(text);
    }
}
