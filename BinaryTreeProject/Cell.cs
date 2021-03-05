using System;
using System.Collections;

namespace BinaryTreeProject
{
    public class Cell<T> : IEnumerable where T: IComparable<T>

    {
    private readonly T _value;
    private Cell<T> _leftCell, _rightCell;

    public Cell(T value)
    {
        _value = value;
    }

    public void Add(T value)
    {
        if (value is not null)
        {
            if (value.CompareTo(_value) == -1)
            {
                AssignValueToCell(value, ref _leftCell);
            }
            else
            {
                AssignValueToCell(value, ref _rightCell);
            }
        }
    }

    private void AssignValueToCell(T value, ref Cell<T> cell)
    {
        if (cell is null)
        {
            cell = new Cell<T>(value);
        }
        else
        {
            cell.Add(value);
        }
    }

    public bool Contains(T value)
    {
        if (_value is not null)
        {
            if (_value.CompareTo(value) == 0)
            {
                return true;
            }

            if (value.CompareTo(_value) == -1)
            {
                return _leftCell?.Contains(value) ?? false; // null-checking
            }
        }

        return _rightCell?.Contains(value) ?? false; // null-checking
    }

    public IEnumerator GetEnumerator()
    {
        if (_leftCell is not null)
        {
            foreach (var value in _leftCell)
            {
                yield return value;
            }
        }

        yield return _value;

        if (_rightCell is not null)
        {
            foreach (var value in _rightCell)
            {
                yield return value;
            }
        }
    }
    }
}