using System.Collections;
using System.Collections.Generic;


namespace CommonServerAPI 
{
    public interface IServer
    {
        string Ping();
        Response Execute(Request request);

    }

    public abstract class Request
    {

    }

    public abstract class Response
    {

    }
}
