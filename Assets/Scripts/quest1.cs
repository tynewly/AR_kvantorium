using TMPro;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class quest1 : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public GameObject Canvas_quest;
    public Button[] buttons;
    public GameObject exit;
    public GameObject ship;
    private bool hasInteracted = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //основной прикол здесь смотри, у теб€ скрип там вырубалс€ и тут вырубалс€ по-этому он нормально сканировалс€ только со второго раза
       //пон€тненько? «а кого? Ќепон€л ничего не писал.Ќо € не вижу взаимосв€зи между тем .что € 2 раза написала canvas_quest и у мен€ сканировалось тока с 2 раза.
        //Canvas_quest.SetActive(false);

        //€ голосом записал слушаю
        exit.SetActive(false);
        ship.SetActive(true);
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
        Text.text = "¬ы испугались и решили откупитьс€. ќтдайте 1 любую единицу товара";
        buttons[1].interactable = false;
        buttons[2].interactable = false;
        exit.SetActive(true);
       
    }

    public void button2()
    {
        Text.text = "¬ы не повелись на провокации. Ѕросьте кубик, он определит исход драки";
        buttons[0].interactable = false;
        buttons[2].interactable = false;
        exit.SetActive(true);
        
    }

    public void button3()
    {
        Text.text = "ѕротивники оказались слишком сильны, вернитесь на 2 шага назад";
        buttons[1].interactable = false;
        buttons[0].interactable = false;
        exit.SetActive(true);
        
    }


    // Update is called once per frame
    void Update()
    {

    }
}
