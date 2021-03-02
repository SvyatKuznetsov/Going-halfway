using UnityEngine;
using UnityEngine.UI;

public class ButtonAlphaReduction : MonoBehaviour
{
    private Image _image;

    void Start()
    {
        GetComponent<Image>().alphaHitTestMinimumThreshold = 0.4f;
        Destroy(this);
    }
}