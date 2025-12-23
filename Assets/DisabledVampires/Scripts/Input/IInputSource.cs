using UnityEngine;
using SimpleInputNamespace;

public interface IInputSource 
{
    
}

public class InputSource : IInputSource
{
    public void Test()
    {
        var x = SimpleInput.GetAxis("Horizontal");
        var y = SimpleInput.GetAxis("Vertical");
    }
}
