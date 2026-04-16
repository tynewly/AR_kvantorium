using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Russian_ancient_script : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject image_chronicle;
    public GameObject text_chronicle;
    public GameObject text_down;
    public GameObject book;
    public GameObject variation_1;
    public GameObject variation_2;
    public GameObject variation_3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
           
    }
    public void Target_found()
    {
        Canvas.SetActive(true);
        image_chronicle.SetActive(false);
        text_chronicle.SetActive(false);
        text_down.SetActive(true);
        book.SetActive(true);
        variation_1.SetActive(false);
        variation_2.SetActive(false);
        variation_3.SetActive(false);
    }
    public void book_touch()
    {
        book.SetActive(false);
        image_chronicle.SetActive(true);
        text_chronicle.SetActive(false);
    }
    public void  {

    // Update is called once per frame
    void Update()
    {
        
    }
}
