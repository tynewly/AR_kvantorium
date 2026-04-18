using UnityEngine;

public class hideScript : MonoBehaviour
{
    public GameObject Canvas_quest;
    public GameObject Canvas_quiz;
    public GameObject Canvas_start;
    private void Start()
    {
        //а не могу край уже далеко ушли, ну суть в том что у тебя канвас квест и квиз не прописан был
        //не было я их сам прописывал. Не суть это не столь важно это начало только идем дальше понятно? да
        Canvas_start.SetActive(true);
        Canvas_quest.SetActive(false);
        Canvas_quiz.SetActive(false);

    }
}
    
