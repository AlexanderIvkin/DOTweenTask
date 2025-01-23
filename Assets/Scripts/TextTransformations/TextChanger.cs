using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _delay;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private string _changedText = "Заменил";
    private string _addedText = " и добавил";
    private string _scrambledText = "Перебрал буквы";

    private void Start()
    {
        CreateSequence().Play();
    }

    private Sequence CreateSequence()
    {
        Tweener tweenerChange = _text.DOText(_changedText, _duration).SetDelay(_delay);
        Tweener tweenerAdd = _text.DOText(_addedText, _duration).SetRelative().SetDelay(_delay);
        Tweener tweenerScramble = _text.DOText(_scrambledText, _duration, true, ScrambleMode.All).SetDelay(_delay);

        Sequence sequence = DOTween.Sequence();

        sequence.Append(tweenerChange)
            .Append(tweenerAdd)
            .Append(tweenerScramble)
            .SetLoops(_repeats, _loopType);

        return sequence;
    }
}
