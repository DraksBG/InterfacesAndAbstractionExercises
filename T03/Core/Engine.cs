using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using T03.Models;

namespace T03
{
   public class Engine
   {
       private Smartphone smartphone;
       private IList<string> phoneNumbers;
       private IList<string> urls;

       public Engine()
       {
           this.smartphone = new Smartphone();
           this.phoneNumbers = new List<string>();
           this.urls = new List<string>();
       }

       public void Run()
       {
           this.phoneNumbers = Console.ReadLine().Split().ToList();
           this.urls = Console.ReadLine().Split().ToList();

           callPhoneNumbere();
           BrowseUrls();
       }

       private void BrowseUrls()
       {
           foreach (var url in urls)
           {
               try
               {
                   Console.WriteLine(this.smartphone.Browse(url));
               }
               catch (ArgumentException ae)
               {
                   Console.WriteLine(ae.Message);
               }
           }
       }

       private void callPhoneNumbere()
       {
           foreach (var phoneNumber in this.phoneNumbers)
           {
               try
               {
                   Console.WriteLine(this.smartphone.Call(phoneNumber));
               }
               catch (ArgumentException ae)
               {
                   Console.WriteLine(ae.Message);
               }
           }
       }
   }
}
