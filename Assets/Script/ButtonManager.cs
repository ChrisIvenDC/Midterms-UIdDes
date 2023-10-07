using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonManager : MonoBehaviour
{
    public GameObject Leafimg;
    [SerializeField] private CanvasGroup LeafGroup;
    public Rigidbody LeafRigid;


    public void FadeScale()
    {
        Leafimg.transform.DOScale(3f, 0.5f).OnComplete(() =>
        {
            Leafimg.transform.DOScale(5.3f, 0.5f);
        });
        LeafGroup.DOFade(0f, 0.5f).OnComplete(() => {
            LeafGroup.DOFade(1, 0.5f);
        });
       
    }

    public void Zoom()
    {
        Leafimg.transform.DOScale(0f, 0.5f).OnComplete(() =>
        {
            Leafimg.transform.DOScale(5.3f, 0.5f);
        });
    }

    public void Flip()
    {
        LeafRigid.DORotate(new Vector3(0, 360, 0), 1,RotateMode.FastBeyond360);
    }

    public void Fly()
    {
        LeafRigid.DOMove(new Vector3(540, 2500, 0), 1).SetEase(Ease.InBounce).OnComplete(() =>
        {
            LeafRigid.DOMove(new Vector3(540, 1385, 0), 1).SetEase(Ease.InBounce);
        });

    }

    public void Fade()
    {
        LeafGroup.DOFade(0f, 0.5f).OnComplete(() => {
            LeafGroup.DOFade(1, 0.5f);
        });
    }

    public void FlipUpsidedown()
    {
        LeafRigid.DORotate(new Vector3(360, 0, 0), 1, RotateMode.FastBeyond360);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
/*540 501*/