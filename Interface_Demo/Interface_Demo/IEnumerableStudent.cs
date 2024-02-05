using System;
using System.Collections;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class StudentCollection : IEnumerable<Student>
{
    private List<Student> students = new List<Student>();

    public void Add(Student student)
    {
        students.Add(student);
    }

    public IEnumerator<Student> GetEnumerator()
    {
        return students.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class MyCollection
{
    private int[] data = { 1, 2, 3, 4, 5 };

    public IEnumerable<int> GetCollection()
    {
        return data;
    }
}
