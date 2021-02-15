using UnityEngine;

namespace HelloTicher
{
    public abstract class Player : MonoBehaviour
    {
        public float Speed = 3.0f;

        public abstract void Move(float x, float y, float z);

    }
}
