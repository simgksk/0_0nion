using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class WorkTime : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] timeText;
    [SerializeField] GameObject lockPanel;
    [SerializeField] GameObject finishWork;
    public GameObject timer;
    [SerializeField] TextMeshProUGUI payText;
    float time = 11;
    int min;
    int sec;
    int rd;
    GameObject work;

    private void Awake()
    {
        work = GameObject.FindWithTag("WorkTimer");
    }

    void Start()
    {
        timer.SetActive(true);
        timeText[0].text = "00";
        timeText[1].text = "00";
        rd = Random.Range(1000, 2000);
    }

    public void Update()
    {
        Timer();
    }

    public void Timer()
    {
        //timer.SetActive(true);
        time -= Time.deltaTime;

        min = Mathf.FloorToInt(time / 60);
        sec = Mathf.FloorToInt(time % 60);

        if (min <= 0 && sec <= 0)
        {
            min = 0;
            sec = 0;
        }

        timeText[0].text = min.ToString("D2");
        timeText[1].text = sec.ToString("D2");

        if (time <= 11)
        {
            lockPanel.SetActive(true);
        }
        if (time <= 0)
        {
            lockPanel.SetActive(false);
            timer.SetActive(false);
            if (finishWork == null) Debug.Log("null");
            finishWork.SetActive(true);
            
            payText.text = $": {rd} $";
        }
    }

    public void GetPay()
    {
        finishWork.SetActive(false);

        GameManager.Instance().AddCoin(rd);
        int myResult = GameManager.Instance().GetCoin();
        Destroy(work);

    }
}
