using UnityEngine;

public class ButtonBack : MonoBehaviour
{
    public void CheckPressButton()
    {
        Invoke(nameof(UnSet), 1f);
    }
    
    private void UnSet()
    {
        gameObject.SetActive(false);
    }
}
