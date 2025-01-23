using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;


[RequireComponent(typeof(Renderer))]
public class ColorChanger : LoopedTween
{
    private Material _material;

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
    }

    protected override Tweener GetTweenForLoop()
    {
        Tweener tweener = ChangeColorTweener()
            .OnStepComplete(() => ChangeColorTweener());

        return tweener;
    }

    private Tweener ChangeColorTweener()
    {
        return _material.DOColor(GenerateColor(), Duration);
    }

    private Color GenerateColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}
