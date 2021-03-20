using System;

namespace MyFirstLibrary
{
    public class MyFirstList
    {
        public int Length { get; private set; }
        private int[] _array;
        private readonly Random _random = new Random();

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

        public MyFirstList(int[] array)
        {
            if (!(array == null))
            {
                Length = 0;
                _array = new int[array.Length];

                for (int i = 0; i < array.Length; ++i)
                {
                    Add(array[i]);
                }
            }
            else
            {
                throw new Exception();
            }

        }

        public MyFirstList(MyFirstList value)
        {
            Length = value.Length;
            _array = value._array;
        }

        private void Resize()
        {
            if (Length >= _array.Length || (Length < _array.Length / 2))
            {
                int newLength = (int)(Length * 1.33d + 1);
                int[] tempArray = new int[newLength];

                for (int i = 0; i < Length; i++)
                {
                    tempArray[i] = _array[i];
                }

                _array = tempArray;
            }
        }

        private void ShiftLeft(int index, int nElements)
        {
            for (int i = index; i < Length; i++)
            {
                _array[i] = _array[i + nElements];
            }
        }

        private void ShiftRight(int index, int nElements)
        {
            for (int i = Length - 1; i > index; i--)
            {
                _array[i] = _array[i - nElements];
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
                    _array[i + 1] = _array[i];
                }

                --Length;
            }

            Resize();
        }

        public void RemoveByIndex(int index)
        {
            if (Length > 0)
            {
                for (int i = Length; i >= index; --i)
                {
                    _array[i + 1] = _array[i];
                }

                Resize();
                --Length;
            }
        }

        public void RemoveNElements(int nElements)
        {
            if (Length >= nElements)
            {
                if (nElements >= 0)
                {
                    Length -= nElements;
                }
            }
            else
            {
                Length = 0;
            }

            Resize();
        }

        public void RemoveNElementsFromStart(int nElements)
        {
            if (Length >= nElements)
            {
                if (nElements >= 0)
                {
                    Length -= nElements;
                    ShiftLeft(0, nElements);
                }
                else
                {
                    Length = 0;
                }

                Resize();
            }

        }

        public void RemoveElementsByIndex(int nElements, int index)
        {
            if (Length >= nElements)
            {
                if (nElements >= 0)
                {
                    Length -= nElements;
                    ShiftRight(index, nElements);
                }
            }

            else
            {
                Length = index;
            }

            Resize();
        }

        public void Reverse()
        {
            int temp = 0;

            for (int i = 0; i < Length / 2; i++)
            {
                temp = _array[i];
                _array[i] = _array[Length - i - 1];
                _array[Length - i - 1] = temp;
            }
        }

        public void FindMaxElement()
        {
            int i;
            int max = _array[0];

            for (i = 1; i < Length - 1; i++)
            {
                if (_array[i] > max)
                max = _array[i];
            }  
        }

        public void FindMinElement()
        {
            int i;
            int min = _array[0];

            for (i = 1; i < Length - 1; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }
        }

        public void MaxIndex()
        {
            int i;
            int max = _array[0];
            int maxIndex = 0;

            for (i = 1; i < Length - 1; i++)
                if (_array[i] > max)
                {
                    max = _array[i];
                    maxIndex = i;
                }
        }

        public void MinIndex()
        {
            int i;
            int min = _array[0];
            int minIndex = 0;

            for (i = 1; i < Length - 1; i++)
                if (_array[i] < min)
                {
                    min = _array[i];
                    minIndex = i;
                }
        }

        public void SortByAscending()
        {
            for (int i = 0; i < Length - 1; i++)
            {
                for (int j = 0; j < Length - i - 1; j++)
                {
                    if (_array[j] > _array[j + 1])
                    {
                        int temp = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = temp;
                    }
                }
            }
        }

        public void SortByDescending()
        {
            for (int i = 0; i < Length - 1; i++)
            {
                for (int j = 0; j < Length - i - 1; j++)
                {
                    if (_array[j] < _array[j + 1])
                    {
                        int temp = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = temp;
                    }
                }
            }
        }

        public void Replace(int index, int value)
        {
            if (index >= 0 && index < Length)
            {
                _array[index] = value;
            }
        }

        public int FindFirstIndexByValue(int value)
        {
            for (int i = 0; i <= Length; i++)
            {
                if (_array[i] == value)
                    return i;
            }

            return -1;
        }

        public int GetLength() => Length;

        public int RemoveFirstElementByValue(int value)
        {
            var index = FindFirstIndexByValue(value);

            if (index != -1)
            {
                RemoveByIndex(index);
                return index;
            }

            return -1;
        }

        public void RemoveByIndex1(int index)
        {
            int i;
            for (i = 0; i < Length; i++)
                if (_array[i] == index)
                    break;

            if (i < Length)
            {
                Length--;
                for (int j = i; j < Length; j++)
                    _array[j] = _array[j + 1];
            }

            Resize();
        }

        public void Print()
        {
            for (int i = 0; i <= Length - 1; i++)
            {
                Console.WriteLine(_array[i]);
            }
        }

        public void InitializeByRandomInfo()
        {
            Length = _random.Next(5, 15);
            _array = new int[Length];

            for (int i = 0; i <= Length - 1; i++)
            {
                _array[i] = _random.Next(0, 100);
            }
        }
    }
}
