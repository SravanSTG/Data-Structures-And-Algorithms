using System;

class MyArray
{
    private int length;
    private Object[] data;

    private MyArray()
    {
        this.length = 0;
        this.data = new Object[1];
    }

    private Object Get(int index)
    {
        return data[index];
    }

    private Object[] Push(Object item)
    {
        if (this.data.Length == this.length)
        {
            Object[] temp = new Object[this.length];
            Array.Copy(this.data, temp, length);
            this.data = new Object[length + 1];
            Array.Copy(temp, this.data, length);
        }

        this.data[this.length] = item;
        this.length++;
        return this.data;
    }

    private Object Pop()
    {
        Object toPop = data[this.length - 1];
        this.data[this.length - 1] = null;
        this.length--;
        return toPop;
    }

    private Object Delete(int index)
    {
        Object itemToDelete = data[index];
        ShiftItems(index);
        return itemToDelete;
    }

    private void ShiftItems(int index)
    {
        for (int i = index; i < length - 1; i++)
        {
            data[i] = data[i + 1];
        }
        data[length - 1] = null;
        length--;
    }

    static void Main(string[] args)
    {
        MyArray myArray = new MyArray();

        myArray.Push("Hello");
        myArray.Push("World");
        myArray.Push("!");

        //for (int i = 0; i < myArray.length; i++)
        //{
        //    Console.WriteLine(myArray.Get(i));
        //}

        //myArray.Pop();

        myArray.Delete(1);

        for (int i = 0; i < myArray.length; i++)
        {
            Console.WriteLine(myArray.Get(i));
        }

        Console.Read();
    }
}
