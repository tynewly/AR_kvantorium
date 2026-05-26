using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Trade_Tver : MonoBehaviour
{
    public GameObject dialoge;
    public GameObject canvas;
    public GameObject sprite_front;
    public GameObject text_pole;
    public TextMeshProUGUI text_pole1;
    public GameObject sprite_right_hand;
    public GameObject sprite_two_hand;
    public GameObject next;
    public GameObject next1;
    public GameObject trade;
    public GameObject exit;
    public GameObject price;

    public ShowModel showModel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvas.SetActive(false);
        showModel.ShowDiorama();
        dialoge.SetActive(false);
        text_pole.SetActive(false);
        sprite_front.SetActive(false);
        sprite_right_hand.SetActive(false);
        sprite_two_hand.SetActive(false);
        trade.SetActive(false);
        next.SetActive(false);
        next1.SetActive(false);
        price.SetActive(false);

    }

    public void TargetFound()
    {
        canvas.SetActive(true);
        
    }


    public void Dialoge()
    {
        dialoge.SetActive(false);
        sprite_front.SetActive(true);
        text_pole.SetActive(true);
        sprite_right_hand.SetActive(false);
        sprite_two_hand.SetActive(false);
        trade.SetActive(false);
        next.SetActive(true);
        next1.SetActive(false);
        price.SetActive(false);
    }

    public void Next()
    {
        dialoge.SetActive(false);
        sprite_front.SetActive(false);
        sprite_right_hand.SetActive(true);
        sprite_two_hand.SetActive(false);
        trade.SetActive(false);
        price.SetActive(false);
        text_pole.SetActive(true);
        text_pole1.text = "“орг там велик и люден, а купцы тамошние по всей земле нашей почтены за разум и честность";
        next.SetActive(false);
        next1 .SetActive(true);
    }

    public void Next1()
    {
        dialoge.SetActive(false);
        sprite_front.SetActive(false);
        sprite_two_hand.SetActive(true);
        sprite_right_hand.SetActive(false);
        price.SetActive(false);
        text_pole.SetActive(true);
        text_pole1.text = "Ќе изволите ли товара коего вз€ти?";
        next1.SetActive(false);
        next.SetActive(false);
        trade.SetActive(true);

    }
    public void Enter_trade()
    {
        dialoge.SetActive(false);
        sprite_front.SetActive(false);
        price.SetActive(true);
        sprite_two_hand.SetActive(false);
        text_pole.SetActive(false);
        trade.SetActive(false);
        next1.SetActive(false);
        next.SetActive(false);
        exit.SetActive(true);
    }

    public void Exit()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
