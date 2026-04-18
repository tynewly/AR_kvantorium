using UnityEngine;
using UnityEngine.UI;
public class question : MonoBehaviour 
{
    //этот? да
    public Button exit;
    public GameObject Canvas_quiz;
    public Button[] buttonWrong;
    public Button correctButton;
    public GameObject win;
    public GameObject lose;
    private Color color;
    public float time = 30;
    private bool answer = false;
    public GameObject Quiz_button;



   
    void Start()
    {
        //Canvas_quiz.SetActive(false); //а как он появится если ты канвас с ним выключаекшь?
        win.SetActive(false);
        lose.SetActive(false);
    }

    public void Exit()
    {
        Canvas_quiz.SetActive(false);
    }

    public void Target_quiz_found() //тут с
    {
        Quiz_button.SetActive(true);
        //Canvas_quiz.SetActive(false); // а тут отключаешь ты что сканируешь то? какой метод при сканирвоание метки появляется кнопка квиза, а кнопка квиза активирует его, ну канвас
    }
    public void Quiz() // и тут
    {
        Canvas_quiz.SetActive(true);
        exit.interactable = true;
        Quiz_button.SetActive(false); //кароче уберу лишнее и забилди вот так вот
    }

    public void timeAnswer()
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
    public void wrongAnswer()
    {
        color = Color.red;
        for (int i= 0; i < buttonWrong.Length; i++)
        {
            buttonWrong[i].GetComponent<Image>().color = color;

        }
        correctButton.GetComponent<Image>().color = Color.green;
        lose.SetActive(true);
        answer = true;
    }
    public void correctAnswer()
    {
    color = Color.green;
    correctButton.GetComponent<Image>().color = color;
        for (int i = 0; i < buttonWrong.Length; i++)
        {
            buttonWrong[i].GetComponent<Image>().color = Color.red;
        }
        win.SetActive(true);
        answer = true;

    }

    void FixedUpdate()//это код я писал чтоле? да, ваш почерк. Ну сразу видно умный человек писал ахпхпа конечно а в чем разница fixedUpdate? 
    {
        timeAnswer();
    }
}
