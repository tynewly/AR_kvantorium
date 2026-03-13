using UnityEngine;
using TMPro;

public class quest1 : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public GameObject Canvas_quest;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Canvas_quest.SetActive(false);
    }

    public void correctTarget()
    {
        Canvas_quest.SetActive(true);
    }

    public void button1()
    {
        Text.text = "knkinkj";
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
