using UnityEngine;
using DG.Tweening;

public class SphereMover : LoopedTween
{
    [SerializeField] private Transform _targetTransform;

    private Vector3 _targetPosition;

    protected void Awake()
    {
        _targetPosition = _targetTransform.position;
    }

    protected override Sequence ExecuteTween()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOMove(_targetPosition, Duration));

        return sequence;
    }
}
