using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sprechblase : MonoBehaviour {

    public GameObject SpeechField;
    public Transform SpeechCanvas;

    private List<string> rightTexts = new List<string>() {
        "Erinnerung", "Herz", "Leben", "Liebende", "sinnlos", "Schatten"
    };

    private List<string> incorrectTexts = new List<string>()
    {
        "Erinerung", "Erinnerun", "Erimerungg", "Rinrung", "Erihnerung",
        "Hertz", "Härz", "Hehrz", "Hrz", "Herrz",    
        "Lebhen", "Lebben", "Lebn", "Lbn", "Lehben",                                               
        "Liepende", "Liebente", "Libende", "Lbnde", "Liehbende",                                               
        "sinlos", "snlos", "snls", "sinloss", "sienlos",
        "Schaaten", "Schadden", "Schaten", "Schttn", "Shatten"
    };

   
	// Use this for initialization
	void Start () {
        InstantiateRandomText();
	}
	
	// Update is called once per frame
	void Update () {
        InstantiateRandomText();
	}

    void InstantiateRandomText()
    {
        // Sprechfeld initialisieren und referenz auf das TextComponent setzen
        Text text = Instantiate(SpeechField).GetComponent<Text>();

        // Sprechfeld als kind vom Canvas setzen
        text.transform.parent = SpeechCanvas;

        // Den Text auswählen:
        string chosenText;
        if (Random.Range(0.0f, 100.0f) < 50.0f) // 50% Wahrscheinlichkeit für korrekten text
        {
            chosenText = rightTexts[Random.Range(0, rightTexts.Count)];
        }
        else
        {
            chosenText = incorrectTexts[Random.Range(0, incorrectTexts.Count)];
        }

        text.text = chosenText;
    }

    // Wenn die Sprechblase eingesammelt ist kannst du den korrekten text aus der Liste entfernen:
    // Das kannst du auch in dem Script von der Truhe machen, bei OnTriggerEnter
    void OnRightTextCollected(string correctText)
    {
        rightTexts.Remove(correctText);
    }
}
