using System.Collections;

namespace Layihe2023.Models;

public class GenericStore<T> : IEnumerable<T>
    where T : class, IEquatable<T>,IdIntarface

{
    T[] data = new T[0];

    public int Id => throw new NotImplementedException();

    public void CreateAdd(T item)
    {
        int length = data.Length;
        Array.Resize(ref data, length + 1);
        data[length] = item;
    }
    public void AddEmployee()
    {

    }
    public void GetAllDepartment()
    {

    }

    public T UpdateDepartment(T name)
    {
        var data1 = Array.Find(data,  item=> item.Name ==name);

        return data1;
    }
    public void GetDepartmentEmployees()
    {

    }





    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

