using System.Collections;
using System.Collections.Generic;

public class Family : IEnumerable<Person>
{
    private List<Person> members = new List<Person>();

    public void AddMember(Person person)
    {
        members.Add(person);
    }

    public IEnumerator<Person> GetEnumerator()
    {
        return members.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
