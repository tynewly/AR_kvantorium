using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class quest1 : MonoBehaviour
{
    public TextMeshProUGUI TextForUser;
    public GameObject Canvas_quest;
    public Button[] buttons;
    public GameObject exit;
    public GameObject ship;
    private bool hasInteracted = false;
    public TMP_InputField inputField;
    public GameObject inputField1;
    public GameObject confimAnswer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //основной прикол здесь смотри, у теб€ скрип там вырубалс€ и тут вырубалс€ по-этому он нормально сканировалс€ только со второго раза
       //пон€тненько? «а кого? Ќепон€л ничего не писал.Ќо € не вижу взаимосв€зи между тем .что € 2 раза написала canvas_quest и у мен€ сканировалось тока с 2 раза.
        //Canvas_quest.SetActive(false);

        //€ голосом записал слушаю
        exit.SetActive(false);
        ship.SetActive(true);
        inputField1.SetActive(false);
        confimAnswer.SetActive(false);
    }


    public void Exit()
    {
        Canvas_quest.SetActive(false);
        ship.SetActive(false);
        hasInteracted = true;

    }

    public void correctTarget_quest()
    {
        Canvas_quest.SetActive(true);
    }
    //public void correctTarget_quest_lost()
    //{
    //Canvas_quest.SetActive(false);

    //}

   public void lostTarget()
    {
        if(hasInteracted)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].gameObject.SetActive(true);
            }
        }
    }

    public void button1()
    {
        TextForUser.text = "¬ы испугались и решили откупитьс€. ќтдайте 1 любую единицу товара";
        buttons[1].interactable = false;
        buttons[2].interactable = false;
        exit.SetActive(true);
       
    }

    public void button2()
    {
        TextForUser.text = "¬ы не повелись на провокации. Ѕросьте кубик, он определит исход драки";
        buttons[0].interactable = false;
        buttons[2].interactable = false;
        exit.SetActive(true);
        inputField1.SetActive(true);
        confimAnswer.SetActive(true);



}
public void cubeText()
    {
        int userText = Convert.ToInt32(inputField.text);
        if (userText > 0 && userText < 4)
        {
            TextForUser.text = "¬ы получили больших шишек, пропустите следующий ход";
        }
        else if (userText > 3 && userText < 7)
        {
            TextForUser.text = "—илы вам не занимать, возьмите 2 монеты от разбойников";
        }
        else
        {
            TextForUser.text = "¬ведено некорректное число, повторите попытку";
        }

    }

        public void button3()
    {
        TextForUser.text = "ѕротивники оказались слишком сильны, вернитесь на 2 шага назад";
        buttons[1].interactable = false;
        buttons[0].interactable = false;
        exit.SetActive(true);
        
    }


    // Update is called once per frame
    void Update()
    {

    }
}
