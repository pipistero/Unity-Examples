using UnityEngine;

public class Example : MonoBehaviour
{
    private int _clickCount = 0;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _clickCount += 1;
            
            Debugger.Instance.Debug($"Click n.{_clickCount}");
        }
    }
}