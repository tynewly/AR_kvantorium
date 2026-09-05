using UnityEngine;
using TMPro;
using System.Collections;


public class TextContr : MonoBehaviour
{
    //private TextMeshProUGUI dialogueText;
    //private string phrase;
    //private float temp;
    //public GameObject canvasShip;
    private string result;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        //canvasShip.SetActive(false);
    }

    /*public void SetDimensions(string newPhrase, TextMeshProUGUI newDialogueText, float newTemp)
    {
        phrase = newPhrase;
        dialogueText = newDialogueText;
        temp = newTemp; я хз надо ли в этом скрипте хранить значения, как будто нет
    }*/ 
    public void TargetFound()
    {
        /*result = "";
        dialogueText.text = "";
        canvasShip.SetActive(true);
        StartCoroutine(Text());*/
    }

    public IEnumerator Text(string phrase, TextMeshProUGUI dialogueText, float temp)
    {
        result = "";
        for (int i = 0; i < phrase.Length; i++)
        {
            result += phrase[i];
            dialogueText.text = result;
            yield return new WaitForSeconds(temp);
        }
        yield return new WaitForSeconds(1f);

    }


    // Update is called once per frame
    void Update()
    {

    }
}