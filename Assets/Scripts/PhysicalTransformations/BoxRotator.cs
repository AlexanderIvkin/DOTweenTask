using UnityEngine;
using DG.Tweening;

public class BoxRotator : LoopedTween
{
    [SerializeField] private Vector3 _targetRotation;

    protected override Sequence ExecuteTween()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DORotate(_targetRotation, Duration));

        return sequence;
    }
}
