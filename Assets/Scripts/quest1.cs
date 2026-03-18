using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class quest1 : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public GameObject Canvas_quest;
    public GameObject Canvas_quiz;
<<<<<<< HEAD
<<<<<<< Updated upstream
    public Button[] buttons; 
=======
    public GameObject Button_notUse1;
    public GameObject Button_notUse2;
>>>>>>> Stashed changes
=======
    public Button[] buttons;
>>>>>>> 07b30b5b8ca192469643db83c1f9c86de55ee5a7
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Canvas_quest.SetActive(false);
        Canvas_quiz.SetActive(false);
    }

    
    public void Exit()
    { 
    Canvas_quest.SetActive(false);
    }

    public void correctTarget()
    {
        Canvas_quest.SetActive(true);
    }

    public void button1()
    {
        Text.text = "Вы испугались и решили откупиться. Отдайте 1 любую единицу товара";
<<<<<<< Updated upstream
        buttons[1].interactable = false;
        buttons[2].interactable = false;
=======
       
>>>>>>> Stashed changes
    }

    public void button2()
    {
        Text.text = "Вы не повелись на провокации. Бросьте кубик, он определит исход драки";
        buttons[0].interactable = false;
        buttons[2].interactable = false;
    }

    public void button3()
    {
        Text.text = "Противники оказались слишком сильны, вернитесь на 2 шага назад";
        buttons[1].interactable = false;
        buttons[0].interactable = false;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
