using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class FollowFinger : MonoBehaviour
{
    public GameObject Glass;
    public GameObject Button_start;
    public GameObject Canvas_start;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Glass.SetActive(true);
        Canvas_start.SetActive(true);
 
        
    }
    public void Button_startGame()
    {
        Canvas_start.SetActive(false);
        Glass.SetActive(false);
        Button_start.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0) // Если было найдено хоть одно касание?
        {
            Touch touch = Input.GetTouch(0);
          // Touch это тип данных. Он типо берет инфу о пальце и сохраняет в переменную tоuch
            Glass.SetActive(true);
            Glass.transform.position = touch.position;
            Debug.Log("Работает");
        }
        else
        {
            Glass.SetActive(false);
            Debug.Log("Не работает");
        }
        
    }
}
