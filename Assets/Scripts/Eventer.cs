using UnityEngine;
using UnityEngine.Events;

public class Eventer : MonoBehaviour
{
    public UnityEvent OnMouseClicked;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnMouseClicked?.Invoke();
        }
    }
}
