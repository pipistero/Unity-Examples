using UnityEngine;

public abstract class AbstractSingleton<T> : MonoBehaviour where T : AbstractSingleton<T>
{
    protected static T _instance;
    
    public static T Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType<T>();
            }
            
            return _instance;
        }
    }
}
