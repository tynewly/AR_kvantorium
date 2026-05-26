using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Trade_Tver : MonoBehaviour
{
    public GameObject trade;
    public GameObject canvas;
    public GameObject sprite_front;
    public GameObject text_pole;
    public TextMeshProUGUI text_pole1;
    public GameObject sprite_right_hand;
    public GameObject next;
    public GameObject next1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvas.SetActive(false);
        
    }

    public void TargetFound()
    {
        canvas.SetActive(true);
        sprite_right_hand.SetActive(false);
        trade.SetActive(false);
        next.SetActive(false);
        next1.SetActive(false);
    }


    public void Trade()
    {
        sprite_front.SetActive(true);
        text_pole.SetActive(true);
        
    }
    public void TouchText()
    {
        sprite_front.SetActive(false);
        sprite_right_hand.SetActive(true);
        text_pole1.text = "“орг там велик и люден, а купцы тамошние по всей земле нашей почтены за разум и честность";
        next.SetActive(false);
        next1 .SetActive(true);
    }

    public void TouchText1()
    {
        sprite_front.SetActive(false);
        sprite_right_hand.SetActive(true);
        text_pole1.text = "Ќе изволите ли товара коего вз€ти?";
        next1.SetActive(false);
    }
    public void Enter_trade()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
