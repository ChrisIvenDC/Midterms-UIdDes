using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonManager : MonoBehaviour
{
    public Vector3 originalPos, targetPos, targetSize, targetRotation;
    public float speed, rotatedDuration, fadeDuration;

    public GameObject targetGameObj, targetImage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    public void SequenceTween()
    {
        //1st task
        //Sequence.Append(targetGameObj.transform.DOLocalMove(target))
    }

    public void MoveTween()
    {
        targetGameObj.transform.DOLocalMove(targetPos, speed).SetEase(Ease.Linear).OnComplete(() => ReturnPos());
    }

    public void ReturnPos()
    {
        targetGameObj.transform.DOLocalMove(originalPos, speed).SetEase(Ease.Linear);
    }

    public void ScaleTween()
    {
        targetGameObj.transform.DOScale(Vector3.zero, speed).SetEase(Ease.Linear);
    }

    public void FadeTween()
    {
        //targetImage.DOFade(0, fadeDuration);
    }

    public void RotateTween()
    {
        targetGameObj.transform.DOLocalRotate(targetRotation, rotatedDuration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
