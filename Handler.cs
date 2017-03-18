using System;
using System.Collections.Generic;

namespace ZZPMatch.Authentication
{
    public class Handler
    {
       public Response Login(Request request)
       {
		   Console.WriteLine("Returning response");
           return new Response(request.body);
       }
    }

    public class Response
    {
	  public int statusCode { get; set; }
	  public Dictionary<string, string> headers { get; set; }
      public string body { get; set; }
	  
	  public Response(string token)
	  {
		  statusCode = 200;
		  headers = new Dictionary<string, string>() { { "Access-Control-Allow-Origin", "*" }, 
		                                               { "Access-Control-Allow-Credentials", "true" } };
		  body = token;
	  }
    }

    public class Request
    {
      public string body { get; set; }
    }
}
