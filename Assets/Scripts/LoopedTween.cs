using UnityEngine;
using DG.Tweening;

public abstract class LoopedTween : MonoBehaviour
{
    [SerializeField] protected float Duration;
    [SerializeField] private int _repeats = -1;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    private Tweener _tween;

    private void Start()
    {
        _tween = GetTweenForLoop();
        _tween.SetLoops(_repeats, _loopType);
    }

    protected abstract Tweener GetTweenForLoop();
}
