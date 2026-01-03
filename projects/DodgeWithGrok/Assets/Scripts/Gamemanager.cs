using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class Gamemanager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Text TimeText;
    public Text RecordText;
    public GameObject GameoverText;

    private float surviveTime;
    private bool isGamneOVer;

    void Start()
    {
        isGamneOVer = false;
        surviveTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!isGamneOVer)
        {
            surviveTime += Time.deltaTime;
            TimeText.text = "Time:" + (int)surviveTime;
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
            
        }
    }

    public void EndGame()
    {
        isGamneOVer = true;
        GameoverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime");
        if(surviveTime>bestTime)
        {
            bestTime = surviveTime;
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }
        RecordText.text = "Best Record:" + (int)bestTime;
    }
}
