using UnityEngine;
using DG.Tweening;

public class Mover : LoopedTween
{
    [SerializeField] private Vector3 _targetPosition;

    protected override Tweener GetTweenForLoop()
    {
        Tweener tweener = transform.DOMove(_targetPosition, Duration);
        
        return tweener;
    }
}
