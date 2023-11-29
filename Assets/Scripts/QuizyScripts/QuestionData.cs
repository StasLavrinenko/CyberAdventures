using UnityEngine;

[CreateAssetMenu(fileName = "Question", menuName = "ScriptableObject/Question", order = 1)]
public class QuestionData : ScriptableObject
{
    public string Question;
    public string Category;
    [Tooltip("The correct answer should always be listed first, they are ranzomized later")]
    public string[] Answers;
}
