using UnityEngine;
using DG.Tweening;

public class Rotator : LoopedTween
{
    [SerializeField] private Vector3 _targetRotation;

    protected override Tweener GetTweenForLoop()
    {
        Tweener tweener = transform.DORotate(_targetRotation, Duration);
        
        return tweener;
    }
}
