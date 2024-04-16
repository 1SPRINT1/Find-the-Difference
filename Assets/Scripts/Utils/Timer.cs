using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public GameObject lossPanel;
    public TextMeshProUGUI timerText; 

    private void Start()
    {
        if (timerText == null)
        {
            Debug.LogError("Timer text not set!");
            return;
        }

        StartCoroutine(StartCountdown());
    }

    private IEnumerator StartCountdown()
    {
        float countdownValue = 120; 

        while (countdownValue > 0)
        {
            timerText.text = FormatTime(countdownValue); 
            yield return new WaitForSeconds(1f);
            countdownValue--;
        }

        OnCountdownFinished();
    }

    private void OnCountdownFinished()
    {
        lossPanel.SetActive(true); 
    }
    private string FormatTime(float time)
    {
        int minutes = (int)(time / 60);
        int seconds = (int)(time % 60);
        return minutes.ToString("00") + ":" + seconds.ToString("00");
    } 
}
