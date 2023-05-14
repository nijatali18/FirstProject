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

    public T UpdateDepartment(T id)
    {
        var data1 = Array.Find(data,  item=> item.Id ==Id);

        return data1;
    }
    public T DataId(int id) 
    {
        var data1 = Array.Find(data, item => item.Id== Id);

        return data1;
    }
    public void GetDepartmentEmployees()
    {

    }



    public int Count { get { return data.Length; } set { } }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in data)
        {
            yield return item;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

