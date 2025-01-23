using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : LoopedTween
{
    [SerializeField] private Text _text;
    [SerializeField] private float _delay;

    private string _changedText = "Заменил";
    private string _addedText = " и добавил";
    private string _scrambledText = "Перебрал буквы";

    protected override Sequence ExecuteTween()
    {
        Tweener tweenerChange = _text.DOText(_changedText, Duration).SetDelay(_delay);
        Tweener tweenerAdd = _text.DOText(_addedText, Duration).SetRelative().SetDelay(_delay);
        Tweener tweenerScramble = _text.DOText(_scrambledText, Duration, true, ScrambleMode.All).SetDelay(_delay);

        Sequence sequence = DOTween.Sequence();

        sequence.Append(tweenerChange)
            .Append(tweenerAdd)
            .Append(tweenerScramble);

        return sequence;
    }
}
