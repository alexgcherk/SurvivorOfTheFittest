using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;


namespace CommonServerAPI 
{
    public interface IServer
    {
        string Ping();
        Response Execute(Request request);

    }

    public abstract class AbstractCall
    {
        protected AbstractCall()
        {
            Type = GetType().FullName;
        }

        public string Type { get; }
    }

    public class Request: AbstractCall
    {
        
    }

    public class Response: AbstractCall
    {
    }
}
