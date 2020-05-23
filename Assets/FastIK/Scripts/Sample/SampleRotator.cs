using UnityEngine;

namespace DitzelGames.FastIK
{
    public class SampleRotator : MonoBehaviour
    {
        
        void Update()
        {
            //just rotate the object
            transform.Rotate(Time.deltaTime * 90, Time.deltaTime * 90, Time.deltaTime * 90);
        }
    }
}
