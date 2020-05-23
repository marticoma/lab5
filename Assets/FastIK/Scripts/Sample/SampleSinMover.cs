using System.Collections.Specialized;
using UnityEngine;

namespace DitzelGames.FastIK
{
    public class SampleSinMover : MonoBehaviour
    {
        public Vector3 Dir;
        public Vector3 Start;

        private void Awake()
        {
            Start = transform.position;
        }

        void Update()
        {
            //just move the object from a to b and back
            transform.position = Start + Dir * Mathf.Sin(Time.timeSinceLevelLoad) * 0.6f + Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * 0.2f
                 + Vector3.right * Mathf.Sin(Time.timeSinceLevelLoad) * 0.2f;
        }
    }
}
