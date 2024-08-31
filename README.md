What is milldeware ?

<img width="869" alt="image" src="https://github.com/user-attachments/assets/5760d3dc-f992-4b72-8afb-99c1176ca4e8">

Using this middleware workflow, we can have conditional logig to control the flow of the execution. 

Middleware to follow below 2 methods. for Use() method the HttpContext and RequestDelegate is important as input parameters for the method while Run method neds HttpContext. 
the HttpContext provide access to request and response objects 
the RequestDelegate is a deligate type that capable of handellinh http request and generating responses. 
1. use(HttpContext, RequestDelegate)
2. Run(HttpContext)

<img width="869" alt="image" src="https://github.com/user-attachments/assets/15e3fafa-692f-41ce-a807-79736bfa5ff6">

