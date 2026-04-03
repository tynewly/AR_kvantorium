using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class quest1 : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public GameObject Canvas_quest;
    public GameObject Canvas_quiz;
    public GameObject Canvas_start;
    public Button[] buttons;
    public GameObject exit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Canvas_quest.SetActive(false);
        Canvas_quiz.SetActive(false);
        Canvas_start.SetActive(true);
        exit.SetActive(false);
    }

    
    public void Exit()
    { 
       Canvas_quest.SetActive(false);
       Canvas_quiz.SetActive(true);

    }

    public void correctTarget_quest()
    {
        Canvas_quest.SetActive(true);
    }


    public void correctTarget_quiz()
    {
        Canvas_quiz.SetActive(true);
    }

    public void button1()
    {
        Text.text = "Вы испугались и решили откупиться. Отдайте 1 любую единицу товара";
        buttons[1].interactable = false;
        buttons[2].interactable = false;
        exit.SetActive(true);
    }

    public void button2()
    {
        Text.text = "Вы не повелись на провокации. Бросьте кубик, он определит исход драки";
        buttons[0].interactable = false;
        buttons[2].interactable = false;
        exit.SetActive(true);
    }

    public void button3()
    {
        Text.text = "Противники оказались слишком сильны, вернитесь на 2 шага назад";
        buttons[1].interactable = false;
        buttons[0].interactable = false;
        exit.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
