using System;

namespace MyFirstLibrary
{
    public class Lists
    {
        public int Length { get; private set; }
        private int[] _array;

        public Lists()
        {
            Length = 0;
            _array = new int[10];
        }

        public Lists(int value)
        {
            Length = 1;
            _array = new int[11];
            _array[0] = value;
        }

        public Lists(int[] array)
        {
            if (!(array == null))
            {
                Length = array.Length;
                _array = new int[array.Length];

                for (int i = 0; i < array.Length; ++i)
                {
                    _array[i] = (array[i]);
                }
            }
            else
            {
                throw new Exception();
            }

        }

        public Lists(Lists value)
        {
            Length = value.Length;
            _array = value._array;
        }

        public int this[int index]
        {
            get { return _array[index]; }

            set
            {

                if (!(index >= Length || index <= 0))
                {
                    _array[index] = value;
                }

                else
                {
                    throw new IndexOutOfRangeException(" Index out of range ");
                }
            }
        }

        public void Add(int value)
        {
            int lastIndex = Length;
            AddByIndex(value, lastIndex);
        }

        public void AddInStart(int value)
        {
            int startIndex = 0;
            AddByIndex(value, startIndex);
        }

        public void AddByIndex(int value, int index)
        {
            if (Length == _array.Length)
            {
                Resize();
            }

            for (int i = Length; i >= index; --i)
            {
                if (i + 1 < _array.Length)
                {
                    _array[i + 1] = _array[i];
                }
            }

            _array[index] = value;
            ++Length;
        }

        public void Remove()
        {
            --Length;
        }

        public void RemoveFromStart()
        {
            int startIndex = 0;
            RemoveByIndex(startIndex);
        }

        public void RemoveByIndex(int index)
        {
            if (Length > 0)
            {
                for (int i = index; i < Length; ++i)
                {
                    if (i + 1 < _array.Length)
                    {
                        _array[i] = _array[i + 1];
                    }
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
            //if (Length >= nElements)
            //{
            //    if (nElements >= 0)
            //    {
            //        Length -= nElements;
            //        ShiftLeft(0, nElements);
            //    }
            //    else
            //    {
            //        Length = 0;
            //    }

            //    Resize();
            //}

            RemoveNElementsByIndex(0, nElements);

        }

        public void RemoveNElementsByIndex(int nElements, int index)
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

        public int FindMaxElement()
        {
            int i;
            int max = _array[0];

            for (i = 1; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }

            return max;
        }

        public int FindMinElement()
        {
            int i;
            int min = _array[0];

            for (i = 1; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }

            return min;
        }

        public int MaxIndex()
        {
            int i;
            int maxIndex = 0;
            int max = _array[0];

            for (i = 1; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public int MinIndex()
        {
            int i;
            int min = _array[0];
            int minIndex = 0;

            for (i = 1; i < Length - 1; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public int[] SortByAscending()
        {
            for (int i = 0; i < Length - 1; ++i)
            {
                int min = i;

                for (int j = i + 1; j < Length; ++j)
                {
                    if (_array[min] > _array[j])
                    {
                        min = j;
                    }
                }

                Swap(ref _array[i], ref _array[min]);
            }

            return _array;
        }

        public int[] SortByDescending()
        {

            for (int i = 0; i < Length - 1; ++i)
            {
                int max = i;

                for (int j = i + 1; j < Length; ++j)
                {
                    if (_array[max] < _array[j])
                    {
                        max = j;
                    }
                }

                Swap(ref _array[i], ref _array[max]);
            }

            return _array;
        }

        public void RemoveByFirstValue(int value)
        {
            int numberOfElements = 1;
            if (Length > 0)
            {
                for (int i = 0; i < Length; ++i)
                {
                    if (_array[i] == value)
                    {
                        ShiftLeft(i, numberOfElements);
                        --Length;
                        Resize();
                        break;
                    }
                }
            }
        }

        public void RemoveByAllValues(int value)
        {
            for (int i = 0; i < Length; ++i)
            {
                if (value == _array[i])
                {
                    RemoveByIndex(i);
                    --i;
                }
            }
        }

        public void AddList(Lists list)
        {
            if (list != null && list.Length != 0)
            {
                int lastIndex = Length;
                AddArrayListByIndex(list, lastIndex);
            }
        }

        public void AddInStart(Lists list)
        {
            if (list != null && list.Length != 0)
            {
                int firstIndex = 0;
                AddArrayListByIndex(list, firstIndex);
            }
        }

        public void AddArrayListByIndex(Lists list, int index)
        {
            if (list != null && list.Length != 0)
            {
                if (index >= 0 && index <= Length)
                {
                    Length += list.Length;
                    if (Length >= _array.Length)
                    {
                        Resize();
                    }

                    int tempLength = list.Length;
                    for (int i = Length - 1; i >= index; i--)
                    {
                        if (i + tempLength < _array.Length)
                        {
                            _array[i + tempLength] = _array[i];
                        }
                    }

                    int count = 0;
                    for (int i = index; i < Length; i++)
                    {
                        if (count < list.Length)
                        {
                            _array[i] = list[count++];
                        }
                    }
                }

                else
                {
                    throw new IndexOutOfRangeException();
                }
            }

            else
            {
                throw new ArgumentException("List no contains elements");
            }
        }

        public override bool Equals(object obj)
        {
            Lists list = (Lists)obj;
            if (this.Length != list.Length)
            {

                return false;
            }

            for (int i = 0; i < Length; i++)
            {
                if (this._array[i] != list._array[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            string s = string.Empty;

            for (int i = 0; i < Length; i++)
            {
                s += _array[i] + " ";
            }
            return s;
        }

        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void Resize()
        {
            int tempLength = Length;

            if (Length >= _array.Length || (Length < _array.Length / 2))
            {
                tempLength = (int)(Length * 1.33 + 1);
            }

            int[] tempArray = new int[tempLength];

            for (int i = 0; i < Length; i++)
            {
                tempArray[i] = _array[i];
            }

            _array = tempArray;
        }

        private void ShiftLeft(int index, int nElements)
        {
            for (int i = index; i < Length - 1; i++)
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

    }
}
