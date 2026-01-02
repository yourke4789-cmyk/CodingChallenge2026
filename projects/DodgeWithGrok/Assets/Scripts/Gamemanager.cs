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
        }
        else
        {
            /*if(Input.GetKeyDown(KeyCode, R))
            {

            }
            */

        }
    }

    public void EndGame()
    {
        isGamneOVer = true;
        GameoverText.SetActive(true);
        float BestTime = surviveTime;
        if(surviveTime>BestTime)
        {

        }
    }
}
