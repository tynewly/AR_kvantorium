using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class New_translate : MonoBehaviour
{
    [System.Serializable]
    public class Pair
    {
        public Image image;
        public TextMeshProUGUI text;
    }
    [Header("Pairs")]
    public Pair[] pairs = new Pair[3];

    [Header("Colors")]
    public Color normalColor = Color.white;
    public Color selectedColor = Color.yellow;
    public Color matchedColor = Color.green;
    public Color wrongColor = Color.red;

    private Image selectedImage;
    private TextMeshProUGUI selectedText;
    private int matchedCount;

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        ResetVisuals();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
