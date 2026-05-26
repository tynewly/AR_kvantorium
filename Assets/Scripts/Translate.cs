using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Translate : MonoBehaviour
{
    public GameObject Canvas_translate;
    public Button[] card;
    public Button[] variants;
    public bool c0 = false;
    public bool c1 = false;
    public bool c2 = false;
    public bool v0 = false;
    public bool v1 = false;
    public bool v2 = false;
    private Color color;
    public TextMeshProUGUI Text;
    public int count = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }
    

    public void correctTarget_translate()
    {
        Canvas_translate.SetActive(true);
  
    }

    public void Exit()
    {
        Canvas_translate.SetActive(false);

    }
    public void card_0()
    {
        card[1].interactable = false;
        card[2].interactable = false;
        c0 = true;
    }
    public void card_1()
    {
        card[0].interactable = false;
        card[2].interactable = false;
        c1 = true;
    }
    public void card_2()
    {
        card[0].interactable = false;
        card[1].interactable = false;
        c2 = true;
    }
    public void var_0()
    {
        variants[1].interactable = false;
        variants[2].interactable = false;
        v0 = true;
    }
    public void var_1()
    {
        variants[0].interactable = false;
        variants[2].interactable = false;
        v1 = true;
    }
    public void var_2()
    {
        variants[0].interactable = false;
        variants[1].interactable = false;
        v2 = true;
    }


    // Update is called once per frame
    void Update()
    {
        if( c0 == v0)
        {

            card[1].interactable = true;
            card[2].interactable = true;
            variants[1].interactable = true;
            variants[2].interactable = true; //но тогда я смогу нажать и на карту 1 и на карту 2, а мне такое не надо
            card[0].IsDestroyed();
            variants[0].IsDestroyed();
            count++;
            Text.text = $"Верно сопоставлено вариантов: {count} ";
        }
        else if (c1 == v1)
        {

            card[0].interactable = true;
            card[2].interactable = true;
            variants[0].interactable = true;
            variants[2].interactable = true; //но тогда я смогу нажать и на карту 1 и на карту 2, а мне такое не надо
            card[1].IsDestroyed();
            variants[1].IsDestroyed();
            count++;
            Text.text = $"Верно сопоставлено вариантов: {count} ";
        }
        else if (c2 == v2)
        {

            card[0].interactable = true;
            card[1].interactable = true;
            variants[0].interactable = true;
            variants[1].interactable = true; //но тогда я смогу нажать и на карту 1 и на карту 2, а мне такое не надо
            card[2].IsDestroyed();
            variants[2].IsDestroyed();
            count++;
            Text.text = $"Верно сопоставлено вариантов: {count} ";
        }
        else
        {
            color = Color.red;
            Text.text =  $"Вы проиграли, правильно  вариантов: {count}";
        }
        if ( count == 3)
        {
            Text.text = "Вы победили! Получите 2 монеты";
        }
       
    }
}
