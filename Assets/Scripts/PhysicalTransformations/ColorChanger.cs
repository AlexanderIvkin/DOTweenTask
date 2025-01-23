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

    protected override Sequence ExecuteTween()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_material.DOColor(GenerateColor(), Duration))
            .OnStepComplete(() => _material.DOColor(GenerateColor(), Duration));

        return sequence;
    }

    private Color GenerateColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}
