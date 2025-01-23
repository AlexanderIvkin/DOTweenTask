using DG.Tweening;
using UnityEngine;

public class CollectiveTransformer : LoopedTween
{
    [SerializeField] private Vector3 _targetDirection;
    [SerializeField] private Vector3 _targetRotation;
    [SerializeField] private Vector3 _targetScale;

    protected override Sequence ExecuteTween()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOMove(_targetDirection, Duration))
            .SetRelative()
            .Join(transform.DORotate(_targetRotation, Duration))
            .Join(transform.DOScale(_targetScale, Duration));

        return sequence;
    }
}
