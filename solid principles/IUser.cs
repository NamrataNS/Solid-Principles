using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles
{
   
     //Login, Rigter , LogError, SendEmails : these are the 4 method which  are required to perform Login fuctionality.
     //but  IUser shold not  be concerned about LogError and SendEmail  which can be placed in different interfaces.
     //We are implementing Encapsulation here 
     
    interface IUser
    {
        bool Login(string Username, string password);
        bool Register(string Username, string Password, string email);
        bool LogError(string error);
        bool SendEmail(string emailContents);
    }

    // Single responsibility principle
    //a class should have only a single responsibility(i.e.changes to only one part of the software's specification should be able to affect the specification of the class).

    interface IUser1
    {
        bool Login(string Username, string password);
        bool Register(string Username, string Password, string email);
        
       
    }

    interface ILogger
    {
        bool LogError(string error);
    }


    interface IEmail
    {
        bool SendEmail(string emailContents);
    }



}
