using System;
using System.Collections.Generic;
using UnityEngine;

namespace Custom.Collections
{
    /// <summary>
    /// Generic object pool for efficient object reuse
    /// </summary>
    /// <typeparam name="T">Type of object to pool</typeparam>
    public class ObjectPool<T> where T : Component
    {
        private readonly Queue<T> _pool;
        private readonly T _prefab;
        private readonly Transform _parent;
        private readonly int _maxSize;

        public int PooledCount => _pool.Count;
        public int MaxSize => _maxSize;

        /// <summary>
        /// Creates a new object pool
        /// </summary>
        /// <param name="prefab">Prefab to instantiate</param>
        /// <param name="initialSize">Initial pool size</param>
        /// <param name="maxSize">Maximum pool size</param>
        /// <param name="parent">Parent transform for pooled objects</param>
        public ObjectPool(T prefab, int initialSize = 10, int maxSize = 100, Transform parent = null)
        {
            _prefab = prefab;
            _maxSize = maxSize;
            _parent = parent;
            _pool = new Queue<T>();

            // Pre-populate the pool
            for (int i = 0; i < initialSize; i++)
            {
                CreateNewInstance();
            }
        }

        /// <summary>
        /// Gets an object from the pool
        /// </summary>
        /// <returns>Pooled object or null if pool is empty</returns>
        public T Get()
        {
            if (_pool.Count > 0)
            {
                T obj = _pool.Dequeue();
                obj.gameObject.SetActive(true);
                return obj;
            }

            if (_pool.Count < _maxSize)
            {
                return CreateNewInstance();
            }

            return null;
        }

        /// <summary>
        /// Returns an object to the pool
        /// </summary>
        /// <param name="obj">Object to return</param>
        public void Return(T obj)
        {
            if (obj == null) return;

            if (_pool.Count < _maxSize)
            {
                obj.gameObject.SetActive(false);
                obj.transform.SetParent(_parent);
                _pool.Enqueue(obj);
            }
            else
            {
                // Pool is full, destroy the object
                if (Application.isPlaying)
                {
                    UnityEngine.Object.Destroy(obj.gameObject);
                }
                else
                {
                    UnityEngine.Object.DestroyImmediate(obj.gameObject);
                }
            }
        }

        /// <summary>
        /// Clears the entire pool
        /// </summary>
        public void Clear()
        {
            while (_pool.Count > 0)
            {
                T obj = _pool.Dequeue();
                if (obj != null)
                {
                    if (Application.isPlaying)
                    {
                        UnityEngine.Object.Destroy(obj.gameObject);
                    }
                    else
                    {
                        UnityEngine.Object.DestroyImmediate(obj.gameObject);
                    }
                }
            }
        }

        private T CreateNewInstance()
        {
            T instance = UnityEngine.Object.Instantiate(_prefab, _parent);
            instance.gameObject.SetActive(false);
            _pool.Enqueue(instance);
            return instance;
        }
    }
}
