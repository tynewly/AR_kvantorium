using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using Unity.VectorGraphics;
using UnityEngine.SceneManagement;

public class Russian_ancient_script : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject image_chronicle;
    public GameObject text_chronicle;
    public GameObject text_down;
    public GameObject book;
    //public GameObject variation_1;
   // public GameObject variation_2;
    //public GameObject variation_3;
    public TextMeshProUGUI text_down2;
    public GameObject text_up;
    public TextMeshProUGUI text_up2;
    public TMP_InputField inputField;
    public GameObject inputField1;    

    private int count = 0;
    private string[] correctSeas = { "Каспийское", "Аравийское", "Чёрное" };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SceneManager.LoadScene(2);
        Canvas.SetActive(false);
        
    }

    public void saveText()
    {
        string userText = inputField.text;
        string[] words = userText.Split(' ');
        Debug.Log(words.Length);
        if (words.Length == 3)
        {
            if (words[0] == "Каспийское") 
            {
                count++;
            }
            if (words[1] == "Аравийское") 
            {
                count++;
            }
            if (words[2] == "Чёрное") 
            {
                count++;
            }
            if (count == 3)
            {
                text_up2.text = "Все верно! Получите 1 золотую монету";
            }
            else
            {
                text_up2.text = "Увы ,неверно. Отдайте 1 золотую монету";
            }
        }
        else if (words.Length < 3)
        {
            text_up2.text = "Введено мало морей. Повторите попытку";
            //и типа наверно тут надо чота такое прописать, чтобы дать пользователю ещё раз ввести моря
        }
        else
        {
            text_up2.text = "Введено много морей. Повторите попытку";
            //и типа наверно тут надо чота такое прописать, чтобы дать пользователю ещё раз ввести моря
        }


    }

    public void Target_found()
    {
        //SceneManager.LoadScene(2);
        Canvas.SetActive(true);
        image_chronicle.SetActive(false);
        text_chronicle.SetActive(false);
        text_down.SetActive(true);
        book.SetActive(true);
        //variation_1.SetActive(false);
        //variation_2.SetActive(false);
        //ariation_3.SetActive(false);
        text_up.SetActive(true);
        inputField1.SetActive(false);


    }
    public void book_touch()
    {
        book.SetActive(false);
        image_chronicle.SetActive(true);
        text_chronicle.SetActive(false);
        text_up.SetActive(false);
        text_down2.text = "Нажмите на записи, чтобы прочитать";
        inputField1.SetActive(false);
    }
    public void chronicle_touch()
    {
        text_chronicle.SetActive(true);
        text_down2.text = "Нажмите на надпись, чтобы выйти";
        text_up.SetActive(false);
    }
    public void textDown_touch()
    {
        image_chronicle.SetActive(false);
        text_chronicle.SetActive(false);
        book.SetActive(true);
        //variation_1.SetActive(true);
        //variation_2.SetActive(true);
        //variation_3.SetActive(true);
        text_up.SetActive(true);
        text_down2.text = "Нажмите на книгу, чтобы вспомнить";
        inputField1.SetActive(true);
        text_up2.text = "Через какие моря проходил путь Великого путешественника Афанасия Никитина?";
        //book.transform.position = new Vector3(-189f, 23f, 0f);
        //book.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
