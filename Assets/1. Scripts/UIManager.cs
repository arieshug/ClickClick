using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private Image scoreImg;
    [SerializeField] private TextMeshProUGUI scoreTmp;

    private void Awake()
    {
        Instance = this;
    }

    public void OnScoreChange(int currentScore, int maxScore)
    {
        scoreTmp.text = $"{currentScore}/{maxScore}";
        scoreImg.fillAmount = (float)currentScore / maxScore;
    }
}
