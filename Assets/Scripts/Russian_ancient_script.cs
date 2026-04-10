using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Russian_ancient_script : MonoBehaviour
{
    public GameObject Canvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Canvas.SetActive(false);    
    }
    public void Target_found()
    {
        Canvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
