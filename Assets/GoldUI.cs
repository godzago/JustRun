using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GoldUI : MonoBehaviour
{
    Transform Panel;
    Sequence GoldAnimation;
    public Rigidbody rgb;
    void Start()
    {
        AnimationH�zland�rma();
    }

    public void AnimationH�zland�rma()
    {
        Panel = GameObject.FindGameObjectWithTag("GoldPanel").transform;
        GoldAnimation = DOTween.Sequence();
        GoldAnimation.Append(transform.DOMove(Panel.position, 2).SetEase(Ease.OutSine)).OnComplete(() => Destroy(gameObject));
    }

}
