using UnityEngine;
using TMPro;
using System.Collections;


public class Textcontroller : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private string phrase;
    public GameObject canvasShip;
    private string result;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvasShip.SetActive(false);
    }

    public void TargetFound()
    {
        result = "";
        dialogueText.text = "";
        canvasShip.SetActive(true);
        StartCoroutine(Text());
    }

    public IEnumerator Text()
    {
        for (int i = 0; i < phrase.Length; i++)
        {
            result += phrase[i];
            dialogueText.text = result;
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(1f);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
