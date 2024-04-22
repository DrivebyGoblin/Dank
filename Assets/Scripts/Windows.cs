using UnityEngine;

public class Windows : MonoBehaviour
{
    [SerializeField] private GameObject _windowToOpen;
    [SerializeField] private GameObject _windowToClose;
    
    public void OpenWindow()
    {
        _windowToOpen.gameObject.SetActive(true);
    }

    public void CloseWindow()
    {
        _windowToClose.gameObject.SetActive(false);
    }
}
