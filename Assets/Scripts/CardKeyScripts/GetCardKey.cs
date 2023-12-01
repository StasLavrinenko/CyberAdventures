using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.UI;

public class GetCardKey : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _scoreText;

    private int _score = 0;

    [Header("Events")]
    public UnityEvent _endGetting;

    private void OnTriggerEnter(Collider other)
    {
        _score++;
        _scoreText.text = "Êëþ÷³: " + _score;
        _endGetting.Invoke();
    }

}
