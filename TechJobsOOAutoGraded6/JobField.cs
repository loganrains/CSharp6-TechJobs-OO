﻿namespace TechJobsOOAutoGraded6;

public abstract class JobField
{
    // list reoccuring fields - ID, Next ID, Value
    // list reoccuring constructors - ID, Value
    // list reocuring custom methods - Equals, hashcode, ToString

    public int Id { get; }
    private static int nextId = 1;
    public string Value { get; set; }

    public JobField()
    {
        Id = nextId;
        nextId++;
    }

    public JobField(string value) : this()
    {
        Value = value;
    }

    public override bool Equals(object obj)
    {
        return obj is JobField jobField &&
               Id == jobField.Id;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }

    public override string ToString()
    {
        return Value;
    }
}
