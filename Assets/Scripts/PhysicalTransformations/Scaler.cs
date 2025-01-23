using UnityEngine;
using DG.Tweening;

public class Scaler : LoopedTween
{
    [SerializeField] private Vector3 _targetScale;

    protected override Tweener GetTweenForLoop()
    {
        Tweener tweener = transform.DOScale(_targetScale, Duration);

        return tweener;
    }
}
