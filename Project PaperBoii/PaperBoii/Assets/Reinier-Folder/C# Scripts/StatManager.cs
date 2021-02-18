using UnityEngine;
using TMPro;

public class StatManager : MonoBehaviour
{
    [SerializeField] GameObject deathPanel;
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] TextMeshProUGUI moneyTextPanel;
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] TextMeshProUGUI timeTextPanel;
    [SerializeField] TextMeshProUGUI papersText;
    [SerializeField] TextMeshProUGUI papersTextPanel;
    [SerializeField] float moneyAmount = 0;
    [SerializeField] int paperAmount = 0;
    [SerializeField] float playTime = 0;
    int minutes = 0;

    private static StatManager instance;
    public static StatManager Instance { get => instance; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
            Destroy(this);
    }

    private void Start()
    {
        moneyText.text = "$" + moneyAmount;
        moneyTextPanel.text = "$" + moneyAmount;
        papersText.text = "Papers: " + paperAmount;
        papersTextPanel.text = "Papers: " + paperAmount;
    }

    public void Death()
    {
        deathPanel.SetActive(true);
    }

    private void Update()
    {
        playTime += Time.deltaTime;
        if (playTime > 59.5f)
        {
            playTime = -0.6f;
            minutes += 1;
        }
        string playTimeString = string.Format("{00:00}", playTime);
        timeText.text = "Playtime: " + minutes + ":" + playTimeString;
        timeTextPanel.text = "Playtime: " + minutes + ":" + playTimeString;
    }

    public void AddMoney(float amount)
    {
        moneyAmount += amount;
        moneyText.text = "$" + moneyAmount;
        moneyTextPanel.text = "$" + moneyAmount;
    }

    public void LoseMoney(float amount)
    {
        moneyAmount -= amount;
        moneyText.text = "$" + moneyAmount;
        moneyTextPanel.text = "$" + moneyAmount;
    }

    public void AddPaper(int amount)
    {
        paperAmount += amount;
        papersText.text = "Papers: " + paperAmount;
        papersTextPanel.text = "Papers: " + paperAmount;
    }
    public void LosePaper(int amount)
    {
        paperAmount -= amount;
        papersText.text = "Papers: " + paperAmount;
        papersTextPanel.text = "Papers: " + paperAmount;
    }
}
