using System;

namespace MyFirstLibrary
{
    public class MyFirstList
    {
        public int Length { get; private set; }
        private int[] _array;

        public MyFirstList()
        {
            Length = 0;
            _array = new int[10];
        }

        public MyFirstList(int value)
        {
            Length = 1;
            _array = new int[11];
            _array[0] = value;
        }

        public void Resize()
        {
            if (Length >= _array.Length || (Length < _array.Length / 2))
            {
                Length = (int)(Length * 1.33d + 1);
                int[] tempArray = new int[Length];

                for (int i = 0; i < Length; i++)
                {
                    tempArray[i] = _array[i];
                }

                _array = tempArray;
            }
        }

        public void Add(int value)
        {
            if (Length == _array.Length)
            {
                Resize();
            }

            _array[Length] = value;
            ++Length;
        }

        public void AddInStart(int value)
        {
            if (Length == _array.Length)
            {
                Resize();
            }

            for(int i = Length; i >= 0; --i)
            {
                _array[i + 1] = _array[0];
            }

            _array[0] = value;
            ++Length;
        }

        public void AddByIndex(int value, int index)
        {
            if (Length == _array.Length)
            {
                Resize();
            }

            for (int i = Length; i >= index; --i)
            {
                _array[i + 1] = _array[i];
            }

            _array[0] = value;
            ++Length;
        }

        public void Remove()
        {
            --Length;
            Resize();
        }

        public void RemoveFromStart()
        {
            if (Length > 0)
            {
                for (int i = 0; i < Length; i++)
                {
                    _array[i] = _array[i + 1];
                }

                --Length;
            }

            Resize();
        }

        public void RemoveByIndex(int value, int index)
        {
            if (index > 0)
            {
                Resize();
            }

            for(int i = 0; i < index; i++)
            {
                _array[i] = _array[i + 1];
            }

            _array[0] = value;
            --Length;
        }

        public void RemoveElementsFromEnd(int nElements)
        {
            if (Length >= nElements)
            {
                for (int i = Length; i > 0 ; --i)
                {
                    _array[i] = _array[i - nElements];
                }

                --Length;
            }

            Resize();
        }

        public void RemoveElementsFromStart(int nElements)
        {
            if (Length >= nElements)
            {
                for (int i = 0; i < Length; i++)
                {
                    _array[i + nElements] = _array[0];
                }

                _array[0] = nElements;
                --Length;
            }

            Resize();
        }

        public void RemoveElementsByIndex(int nElements, int index, int value)
        {
            if (Length > index)
            {
                for(int i = 0; i < index; i++)
                {
                    _array[i] = _array[i + nElements];
                }
            }

            _array[0] = nElements;
            --Length;
        }

        public void ReturnLength()
        {

        }
    }
}
