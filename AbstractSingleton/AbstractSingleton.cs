using UnityEngine;

public abstract class AbstractSingleton<T> : MonoBehaviour where T : AbstractSingleton<T>
{
    protected static T _instance;
    public static T Instance => _instance;

    public void Awake()
    {
        if (_instance == null)
        {
            _instance = FindObjectOfType<T>();
            
            DontDestroyOnLoad(this);
            
            return;
        }
        
        Destroy(gameObject);
    }
}
