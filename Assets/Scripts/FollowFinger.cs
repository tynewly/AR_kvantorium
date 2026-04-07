using UnityEngine;
using UnityEngine.UI;

public class FollowFinger : MonoBehaviour
{
    public RawImage Glass;
    public GameObject Button_start;
    public GameObject Canvas_start;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Glass.gameObject.SetActive(false);
        Canvas_start.SetActive(true);
 
        
    }
    void Button_startGame()
    {
        Canvas_start.SetActive(false);
        Glass.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0) // Если было найдено хоть одно касание?
        {
            Touch touch = Input.GetTouch(0);
          // Touch это тип данных. Он типо берет инфу о пальце и сохраняет в переменную tоuch
            Glass.gameObject.SetActive(true);
            Glass.transform.position = touch.position;
        }
        else
        {
            Glass.gameObject.SetActive(false);
        }
        
    }
}
