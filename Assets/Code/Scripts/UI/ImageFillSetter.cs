using UnityEngine;
using UnityEngine.UI;

public class ImageFillSetter : MonoBehaviour
{
    [SerializeField] protected Image bar;
    [SerializeField, ReadOnly] protected float value;
    [SerializeField, ReadOnly] protected float max;

    protected virtual void Update()
    {
        bar.fillAmount = value / max;
    }
}
