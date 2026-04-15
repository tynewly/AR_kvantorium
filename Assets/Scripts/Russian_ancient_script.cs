using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Russian_ancient_script : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject image_chronicle;
    public GameObject text_chronicle;
    public GameObject text_down;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
           
    }
    public void Target_found()
    {
        Canvas.SetActive(true);
        image_chronicle.SetActive(true);
        text_chronicle.SetActive(false);
        text_down.SetActive(true);
    }
    public void chronicle_touch()
    {
        image_chronicle.SetActive(true);
        text_chronicle.SetActive(true);
        text_down.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
