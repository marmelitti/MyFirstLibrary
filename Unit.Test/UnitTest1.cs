using NUnit.Framework;
using System;

namespace MyFirstLibrary.Test
{
    public class MyFirstLibraryTests
    {
        [TestCase(4, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(1, new int[] { 0 }, new int[] { 0, 1 })]
        [TestCase(-100, new int[] { }, new int[] { -100 })]
        [TestCase(0, new int[] { -100 }, new int[] { -100, 0 })]
        [TestCase(939, new int[] { 1, -1489, 0, 0, 10, 2}, new int[] { 1, -1489, 0, 0, 10, 2, 939})]
        public void Add_WhenValidValues_AddLast(int value, int[] actualArray, int[] expectedArray)
        {
            Lists actual = new Lists(actualArray);
            Lists expected = new Lists(expectedArray);

            actual.Add(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, new int[] { 1, 2, 3}, new int[] { 4, 1, 2, 3})]
        [TestCase(4, new int[] { }, new int[] { 4 })]
        [TestCase(-100, new int[] { 10, 0, 98 }, new int[] { -100, 10, 0, 98 })]
        [TestCase(0, new int[] { 90, 87, -10 }, new int[] { 0, 90, 87, -10 })]
        [TestCase(-76, new int[] { }, new int[] { -76 })]
        public void AddInStart_WhenValidValue_AddInStart(int value, int[] actualArray, int[] expectedArray)
        {
            Lists actual = new Lists(actualArray);
            Lists expected = new Lists(expectedArray);

            actual.AddInStart(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2,new int[] { 0, 2, 3, 7 }, new int[] { 0, 2, 1, 3, 7 })]
        [TestCase(1, 2,new int[] { 1, 2 }, new int[] { 1, 2, 1})]
        [TestCase(10, 0, new int[] { 90 }, new int[] { 10, 90 })]
        [TestCase(-90, 3, new int[] { 9, 7, 4, 2, 9 }, new int[] { 9, 7, 4, -90, 2, 9 })]
        [TestCase(0, 9, new int[] { -10, 7, 9, -10090, 56, 8, 9, 5, 6, 8 }, new int[] { -10, 7, 9, -10090, 56, 8, 9, 5, 6, 0, 8 })]
        public void AddByIndex_WhenValidValue_AddByIndex(int value, int index, int[] actualArray, int[] expectedArray)
        {
            Lists actual = new Lists(actualArray);
            Lists expected = new Lists(expectedArray);

            actual.AddByIndex(value, index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase( new int[] { 0, 2, 3, 7 }, new int[] { 0, 2, 3})]
        [TestCase( new int[] { 0 }, new int[] { })]
        [TestCase( new int[] { 45, 8, -89, 8, 7, 6, 4 }, new int[] { 45, 8, -89, 8, 7, 6 })]
        [TestCase( new int[] { -9 }, new int[] { })]
        [TestCase( new int[] { 0, 0, 0 }, new int[] { 0, 0 })]
        public void Remove_WhenValidValues_RemoveValue(int[] actualArray, int[] expectedArray)
        {
            Lists actual = new Lists(actualArray);
            Lists expected = new Lists(expectedArray);

            actual.Remove();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 1, 2}, new int[] { 1, 2 })]
        [TestCase(new int[] { 0 }, new int[] { })]
        [TestCase(new int[] { -9, 98 }, new int[] { 98 })]
        [TestCase(new int[] { 9, 0, 6, 4 }, new int[] { 0, 6, 4 })]
        [TestCase(new int[] { -99, -99, 32, 32 }, new int[] { -99, 32, 32})]
        public void RemoveFromStart_WhenValidValues_RemoveFirstElements(int[] actualArray, int[] expectedArray)
        {
            Lists actual = new Lists(actualArray);
            Lists expected = new Lists(expectedArray);

            actual.RemoveFromStart();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { 0, 1, 2 }, new int[] { 1, 2 })]
        [TestCase(2, new int[] { 0, 1, 2 }, new int[] { 0, 1 })]
        [TestCase(9, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 })]
        [TestCase(0, new int[] { 0 }, new int[] { })]
        [TestCase(3, new int[] { -19, 91, -19, 67 }, new int[] { -19, 91, -19 })]
        public void RemoveByIndex_WhenValidValues_RemoveElementByIndex(int index, int[] actualArray, int[] expectedArray)
        {
            Lists actual = new Lists(actualArray);
            Lists expected = new Lists(expectedArray);

            actual.RemoveByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, new int[] { 0, 1, 2, 6, 8, 9 }, new int[] { })]
        [TestCase(1, new int[] { 0, 1, 2 }, new int[] { 0, 1 })]
        [TestCase(0, new int[] { }, new int[] { })]
        [TestCase(2, new int[] { 0, 0 }, new int[] { })]
        [TestCase(0, new int[] { -9, 8, 0 }, new int[] { -9, 8 ,0 })]
        public void RemoveNElements_WhenValidValues_RemoveNElementsFromEnd(int nElements, int[] actualArray, int[] expectedArray)
        {
            Lists actual = new Lists(actualArray);
            Lists expected = new Lists(expectedArray);

            actual.RemoveNElements(nElements);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] { 0, 1, 2, 6, 8, 9 }, new int[] { 6, 8, 9 })]
        [TestCase(5, new int[] { 0, 1, 2, 6, 8, 9 }, new int[] { 9 })]
        [TestCase(9, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { })]
        [TestCase(1, new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 })]
        public void RemoveNElementsFromStart_WhenValidValues_RemoveNElementsFromStart(int nElements, int[] actualArray, int[] expectedArray)
        {
            Lists actual = new Lists(actualArray);
            Lists expected = new Lists(expectedArray);

            actual.RemoveNElementsFromStart(nElements);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 3, new int[] { 0, 1, 2, 3, 4, 5 }, new int[] { 0, 1, 2 })]
        [TestCase(4, 2, new int[] { 0, 1, 2, 3, 4, 5 }, new int[] { 0, 1 })]
        [TestCase(5, 1, new int[] { 0, 1, 2, 3, 4, 5 }, new int[] { 0 })]
        [TestCase(1, 9, new int[] { -1, -2, -3, -4, 5, 4, 3, 2, 1, 0 }, new int[] { -1, -2, -3, -4, 5, 4, 3, 2, 1 })]
        [TestCase(6, 5, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { })]
        public void RemoveNElementsByIndex_WhenValidValues_RemoveNElementsByIndex(int nElements, int index, int[] actualArray, int[] expectedArray)
        {
            Lists actual = new Lists(actualArray);
            Lists expected = new Lists(expectedArray);

            actual.RemoveNElementsByIndex(nElements, index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 1, 2, 6, 8, 9 }, new int[] { 9, 8, 6, 2, 1, 0 })]
        [TestCase(new int[] { 0, 0 }, new int[] { 0, 0 })]
        [TestCase(new int[] { 98, -28 }, new int[] { -28, 98 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        public void Reverse_WhenValidValues_ReverseTheElementsOfTheArray(int[] actualArray, int[] expectedArray)
        {
            Lists actual = new Lists(actualArray);
            Lists expected = new Lists(expectedArray);

            actual.Reverse();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 4, 7, 9 }, 9 )]
        [TestCase(new int[] { 0, 0 }, 0 )]
        [TestCase(new int[] { 9, -10, -78, 67, -100500}, 67)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { -10, -9, -8, -2}, -2)]
        public void FindMaxElement_WhenValidValues_FindTheBiggestElementOfTheArray(int[] actualArray, int expected)
        {
            Lists array = new Lists(actualArray);

            int actual = array.FindMaxElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 4, 7, 9 }, 1)]
        [TestCase(new int[] { 2, 8, 9, 0, 3, 0 }, 0)]
        [TestCase(new int[] { -9, -4, -7, -2}, -9)]
        [TestCase(new int[] { 99, 99, 99}, 99)]
        [TestCase(new int[] { 1 }, 1)]
        public void FindMinElement_WhenValidValues_FindTheSmallestElementOfTheArray(int[] actualArray, int expected)
        {
            Lists array = new Lists(actualArray);

            int actual = array.FindMinElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 4, 7, 9 }, 4)]
        [TestCase(new int[] { 2, 8, 9, 0, 3, 0 }, 2)]
        [TestCase(new int[] { -9, -9 }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { -9, -8, -7, -6, -5, -4, -3, -2, -1}, 8)]
        public void MaxIndex_WhenValidValues_FindTheBiggestIndexOfTheArray(int[] actualArray, int expected)
        {
            Lists array = new Lists(actualArray);

            int actual = array.MaxIndex();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 4, 7, 9 }, 0)]
        [TestCase(new int[] { 2, 8, 9, 0, 3, 0 }, 3)]
        [TestCase(new int[] { -2, -2 }, 0)]
        [TestCase(new int[] { 0, 0 }, 0 )]
        [TestCase(new int[] { -9, -8, -7, -6, -5, -4, -3, -2, -1}, 0)]
        public void MinIndex_WhenValidValues_FindTheSmallestIndexOfTheArray(int[] actualArray, int expected)
        {
            Lists array = new Lists(actualArray);

            int actual = array.MinIndex();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 3, 7, 5, 89, 9, 78 }, new int[] { 1, 3, 5, 7, 9, 78, 89 })]
        [TestCase(new int[] { 2, 8, 9, 0, 3, 0 }, new int[] { 0, 0, 2, 3, 8, 9 })]
        [TestCase(new int[] { 0, 0 }, new int[] { 0, 0 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5, -6, -7, -8, -9 }, new int[] { -9, -8, -7, -6, -5, -4, -3, -2, -1})]
        [TestCase(new int[] { -1, 2, 3, -10, 9, -78 }, new int[] { -78, -10, -1, 2, 3, 9 })]
        public void SortByAscending_WhenValidValues_SortAllElementsOfArrayFromSmallestToBiggest(int[] actualArray, int[] expectedArray)
        {
            Lists actual = new Lists(actualArray);
            Lists expected = new Lists(expectedArray);

            actual.SortByAscending();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 3, 7, 5, 89, 9, 78 }, new int[] { 89, 78, 9, 7, 5, 3, 1 })]
        [TestCase(new int[] { 2, 8, 9, 0, 3, 0 }, new int[] { 9, 8, 3, 2, 0, 0 })]
        [TestCase(new int[] { 0, 0 }, new int[] { 0, 0 })]
        [TestCase(new int[] { -9, -8, -7, -6, -5, -4, -3, -2, -1}, new int[] { -1, -2, -3, -4, -5, -6, -7, -8, -9})]
        [TestCase(new int[] { 9, -2, -4, 67, 98, 56, 34, -34 }, new int[] { 98, 67, 56, 34, 9, -2, -4, -34 })]
        public void SortByDescending_WhenValidValues_SortAllElementsOfArrayFromBiggestToSmallest(int[] actualArray, int[] expectedArray)
        {
            Lists actual = new Lists(actualArray);
            Lists expected = new Lists(expectedArray);

            actual.SortByDescending();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] { 3, 37, 7, 5, 3, 8 }, new int[] { 37, 7, 5, 3, 8 })]
        [TestCase(0, new int[] { 2, 8, 9, 0, 3, 0 }, new int[] { 2, 8, 9, 3, 0 })]
        [TestCase(9, new int[] { 9, 9 }, new int[] { 9 })]
        [TestCase(-10, new int[] { 98, 98, 10, -10, -10 }, new int[] { 98, 98, 10, -10})]
        [TestCase(8, new int[] { 67, 56, 45, 34, 23, 12, 8 }, new int[] { 67, 56, 45, 34, 23, 12 })]
        public void RemoveByFirstValue_WhenValidValues_RemoveElementByFirstValue(int value, int[] actualArray, int[] expectedArray)
        {
            Lists actual = new Lists(actualArray);
            Lists expected = new Lists(expectedArray);

            actual.RemoveByFirstValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] { 3, 37, 7, 5, 3, 8 }, new int[] { 37, 7, 5, 8 })]
        [TestCase(0, new int[] { 2, 8, 9, 0, 3, 0 }, new int[] { 2, 8, 9, 3 })]
        [TestCase(12, new int[] { 12, 12, 12, 12 }, new int[] { })]
        [TestCase(-1, new int[] { 0, 0, 0, -1, 0, -1, 0 }, new int[] { 0, 0, 0, 0, 0 })]
        [TestCase(1, new int[] { 1, 2, 3, 2, 1, 3, 2, 4, 3 }, new int[] { 2, 3, 2, 3, 2, 4, 3})]
        public void RemoveByAllValues_WhenValidValues_RemoveElementByAllValue(int value, int[] actualArray, int[] expectedArray)
        {
            Lists actual = new Lists(actualArray);
            Lists expected = new Lists(expectedArray);

            actual.RemoveByAllValues(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, new int[] { 45 }, new int[] { 45 })]
        [TestCase(new int[] { }, new int[] { 2, 8, 9, 3 }, new int[] { 2, 8, 9, 3 })]
        [TestCase(new int[] { 23, 34, 56 }, new int[] { 0, 0, 0 }, new int[] { 23, 34, 56, 0, 0, 0 })]
        public void AddList_WhenValidValues_ShouldReturnList(int[] arrayList, int[] arrayAddedList, int[] expectedArray)
        {
            Lists actual = new Lists(arrayList);
            Lists arrayListForAdding = new Lists(arrayAddedList);
            Lists expected = new Lists(expectedArray);

            actual.AddList(arrayListForAdding);

            Assert.AreEqual(expected, actual);
        }
    }
}