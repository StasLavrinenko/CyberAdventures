using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.UI;

public class GetCardKey : MonoBehaviour
{

    public int _score = 0;

    [Header("Events")]
    public UnityEvent _endGetting;

    private void OnTriggerEnter(Collider other)
    {
        _score++;
        _endGetting.Invoke();
    }

}
