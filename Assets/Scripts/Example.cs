using UnityEngine;

public class Example 
{
   public int Test;

}
namespace HelloTeacher
{
   public class Example
   {
      public string Test;
   }
   namespace MyNamespase.HelloTeacher
   {
      public class Example
      {
         public float Test;
      }
   }
   // public class Test : MonoBehaviour
   // {
   //    private void Start()
   //    {
   //       HelloTeacher.MyNamespase.HelloTeacher.Example example1 = new MyNamespase.HelloTeacher.Example();
   //       HelloTeacher.Example example2 = new Example();
   //       global::Example example3 = new global::Example();
   //    }
   // }
     
   
      
      
}
