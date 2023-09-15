using UnityEngine;
using UnityEngine.UI;

public class Debugger : AbstractSingleton<Debugger>
{
    [Header("Texts")] 
    [SerializeField] private Text _text;

    public void Debug(string message)
    {
        if (_text == null)
            return;
        
        _text.text = message;
    }
}