using UnityEngine;

namespace ladder
{
    public class Ladder : MonoBehaviour
    {
        public Vector3 PointPlayer => _pointPlayer;
        public Vector3 RotatePlayer => _rotatePlayer;

        [SerializeField] private Vector3 _pointPlayer;
        [SerializeField] private Vector3 _rotatePlayer;
    }
}
