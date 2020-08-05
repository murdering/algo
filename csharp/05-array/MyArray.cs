using System;

namespace algo05_array
{
    public class MyArray<T> where T : IComparable<T>
    {
        private T[] _arrays;
        private int _capacity { get; set; }
        private int _length { get; set; }

        public MyArray(int capacity)
        {
            _arrays = new T[capacity];
            _capacity = capacity;
        }

        public int Length => _length;

        public T[] Data => _arrays;

        /// <summary>
        /// 插入元素
        /// </summary>
        /// <param name="idx">索引</param>
        /// <param name="item">元素</param>
        public void Insert(int idx, T item)
        {
            if (idx < 0 || idx >= _capacity)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            if (idx <= _length)
            {
                for (int i = _length; i > idx; i--)
                {
                    _arrays[i] = _arrays[i - 1];
                }

                _length++;
            }
            else
            {
                _length = idx;
            }

            _arrays[idx] = item;
        }

        /// <summary>
        /// 删除元素
        /// </summary>
        /// <param name="idx"></param>
        public void Delete(int idx)
        {
            if (idx < 0 || idx >= _capacity)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            if (_length == 0)
            {
                return;
            }

            if (idx == _length - 1) // 移除最后一个元素
            {
                _arrays[idx] = default;
                _length--;
            }
            else if (idx < _length)
            {
                for (int i = idx; i < _length - 2; i++)
                {
                    _arrays[i] = _arrays[i + 1];
                }

                // 最后一个元素哨兵处理
                _arrays[_length - 1] = default;
                _length--;
            }
        }

        /// <summary>
        /// IndexOf
        /// </summary>
        /// <param name="item">元素</param>
        /// <returns>索引</returns>
        public int IndexOf(T item)
        {
            for (int i = 0; i < _length; i++)
            {
                if (_arrays[i].CompareTo(item) == 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}