using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;


///<summary>Class that represents an object</summary>
class Obj
{
    /// <summary>Checks if an obj is an instance of array</summary>
    public static void Print(object myObj)
    {


        Type i = myObj.GetType();
        TypeInfo j = i.GetTypeInfo();
        IEnumerable<PropertyInfo> p_List = j.GetProperties();
        IEnumerable<MethodInfo> my_List = j.GetMethods();
        System.Console.WriteLine("{0} Properties:", j.Name);
        
        foreach (PropertyInfo pp in p_List)
        {
            
            System.Console.WriteLine(pp.Name);
        
        }

        System.Console.WriteLine("{0} Methods:", j.Name);
        
        foreach (MethodInfo mm in my_List)
        {
        
            System.Console.WriteLine(mm.Name);
        
        }


    }
}
