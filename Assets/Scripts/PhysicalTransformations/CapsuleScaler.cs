using UnityEngine;
using DG.Tweening;

public class CapsuleScaler : LoopedTween
{
    [SerializeField] private Vector3 _targetScale;

    protected override Sequence ExecuteTween()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOScale(_targetScale, Duration));

        return sequence;
    }
}
