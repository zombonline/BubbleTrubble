using UnityEngine;
using DG.Tweening;

public class UIAnimation : MonoBehaviour
{
    [SerializeField] Transform Shape;



    public void RotateShape()
    {
        Shape.DORotate(new Vector3(0, 0, 359), 5, RotateMode.Fast).SetLoops
        (-1, LoopType.Restart);
    }
}
