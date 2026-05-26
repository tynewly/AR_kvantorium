using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MatchPairsUI : MonoBehaviour
{
    public GameObject exit;  
    [System.Serializable]
    public class Pair
    {
        public Image image;
        public TextMeshProUGUI text;
    }

    [Header("Answer")]
    public TextMeshProUGUI replica;
    [Header("Pairs")]
    public Pair[] pairs = new Pair[3];

    [Header("Colors")]
    public Color normalColor = Color.white;
    public Color selectedColor = Color.yellow;
    public Color matchedColor = Color.green;
    public Color wrongColor = Color.red;

    private Image selectedImage;
    private TextMeshProUGUI selectedText;
    public GameObject Canvas;

    private int matchedCount;

    private void Start()
    {
        ResetVisuals();
    }

    public void SelectImage(Image image)
    {
        if (IsImageMatched(image))
            return;

        if (selectedImage != null)
            selectedImage.color = normalColor;

        selectedImage = image;
        selectedImage.color = selectedColor;

        CheckMatch();
    }

    public void SelectText(TextMeshProUGUI text)
    {
        if (IsTextMatched(text))
            return;

        if (selectedText != null)
            selectedText.color = normalColor;

        selectedText = text;
        selectedText.color = selectedColor;

        CheckMatch();
    }

    public void Exit()
    {
        Canvas.SetActive(false);

    }
    private void CheckMatch()
    {
        if (selectedImage == null || selectedText == null)
            return;

        if (IsCorrectPair(selectedImage, selectedText))
        {
            selectedImage.color = matchedColor;
            selectedText.color = matchedColor;

            selectedImage.raycastTarget = false;
            selectedText.raycastTarget = false;

            matchedCount++;

            selectedImage = null;
            selectedText = null;
            replica.text = "Так держать!"; // по идее вот тут ворк, потомутчо ты мне написала, что после каждого обнаружения, а не в конце хорошо
            if (matchedCount >= pairs.Length)
            {
                FinishGame();
                //Debug.Log("Все пары найдены!");
            }
        }
        else
        {
            selectedImage.color = wrongColor;
            selectedText.color = wrongColor;
            replica.text = "Неверно, попробуй еще раз";
            Invoke(nameof(ClearWrongSelection), 1f);
        }
    }

    private void ClearWrongSelection()
    {
        if (selectedImage != null)
            selectedImage.color = normalColor;

        if (selectedText != null)
            selectedText.color = normalColor;

        selectedImage = null;
        selectedText = null;
        replica.text = "Сопоставьте незнакомые слова с объектами";//ворк? да
    }

    private bool IsCorrectPair(Image image, TextMeshProUGUI text)
    {
        foreach (Pair pair in pairs)
        {
            if (pair.image == image && pair.text == text)
                return true;
        }

        return false;
    }

    public void FinishGame()
    {
        if (matchedCount == 3)
        {
            replica.fontSize = 80;//типо он изменит только размер текста последней надписи поняла? Я поняла
            replica.text = "Молодец так держать!Радушный странник поделился с вами,что в Персии ценят жемчуг";
            exit.SetActive(true);
        }
    }
    private bool IsImageMatched(Image image)
    {
        return image.raycastTarget == false;
    }

    private bool IsTextMatched(TextMeshProUGUI text)
    {
        return text.raycastTarget == false;
    }

    private void ResetVisuals()
    {
        matchedCount = 0;

        foreach (Pair pair in pairs)
        {
            pair.image.color = normalColor;
            pair.text.color = normalColor;

            pair.image.raycastTarget = true;
            pair.text.raycastTarget = true;
            exit.SetActive(false);
        }
    }
}

