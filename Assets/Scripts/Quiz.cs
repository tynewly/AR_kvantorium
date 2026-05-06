using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Quiz : MonoBehaviour 
{
    //этот? да
    public Button exit;
    public GameObject Canvas_quiz;
    public Button[] buttonWrong;
    public Button correctButton;
    private Color color;
    public float time = 30;
    private bool answer = false;
    public GameObject Quiz_button;
    private bool controlTime = false;
    public TextMeshProUGUI quiz_question;




    void Start()
    {
        //Canvas_quiz.SetActive(false); //а как он появится если ты канвас с ним выключаекшь?
        GetComponent<Quiz>();
    }

    public void Exit()
    {
        Canvas_quiz.SetActive(false);
    }

    public void Target_quiz_found() //тут с
    {
        Canvas_quiz.SetActive(true);
        Debug.Log("Scan");
        controlTime = true;
        

        //Canvas_quiz.SetActive(false); // а тут отключаешь ты что сканируешь то? какой метод при сканирвоание метки появляется кнопка квиза, а кнопка квиза активирует его, ну канвас
    }
    public void Quiz1() // и тут
    {
        exit.interactable = true;
        Quiz_button.SetActive(false); //кароче уберу лишнее и забилди вот так вот
    }

    public void timeAnswer()
    {
        if (controlTime == true)
        {
            if (answer == false)
            {
                time = time - Time.deltaTime;
                if (time < 0)
                {
                    wrongAnswer();

                }

                Debug.Log(time);
            }

        }
       
                 
    }    
    public void wrongAnswer()
    {
        color = Color.red;
        for (int i= 0; i < buttonWrong.Length; i++)
        {
            buttonWrong[i].GetComponent<Image>().color = color;

        }
        correctButton.GetComponent<Image>().color = Color.green;
        answer = true;
        Quiz1();
        quiz_question.text = "Увы неверно, пропустите ход";
    }
    public void correctAnswer()
    {
    color = Color.green;
    correctButton.GetComponent<Image>().color = color;
        for (int i = 0; i < buttonWrong.Length; i++)
        {
            buttonWrong[i].GetComponent<Image>().color = Color.red;
        }
        answer = true;
        Quiz1();
        quiz_question.text = "Все так, за вашу эрудированность вас наградили сведением, что в Казани не хватает меха";
    }

    void FixedUpdate()//это код я писал чтоле? да, ваш почерк. Ну сразу видно умный человек писал ахпхпа конечно а в чем разница fixedUpdate? 
    {
        timeAnswer();
    }
}
