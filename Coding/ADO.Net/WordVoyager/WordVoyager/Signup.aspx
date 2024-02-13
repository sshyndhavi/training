<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="WordVoyager.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<head>
    <title>SignUp</title>
    <style>
        body {
            

            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }


        
        

        form {
            width: 300px;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            background-color: #f9f9f9;
        }

        input[type="text"],
        input[type="email"],
        input[type = "text"],
        input[type="password"],
        textarea,
        select {
            width: calc(100% - 12px);
            padding: 6px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 3px;
        }

        input[type="submit"] {
            width: 100%;
            padding: 10px;
            border: none;
            border-radius: 3px;
            background-color: #007bff;
            color: #fff;
            cursor: pointer;
        }

        input[type="submit"]:hover {
            background-color: #0056b3;
        }
    </style>
</head>

<body>
     <header runat="server">
     
 </header>
 <main runat="server">
     <form id="signupForm" action="signupHandler.aspx" method="post" runat="server">
         <div>
             
             <label for="fullname">Full Name:</label>
             <input type="text" id="fullname" name="fullname" required>
                 
         </div>
         <br /> 
         <div>
             
             <label for="email">Email:</label>
             <input type="email" id="email" name="email" required>
                 
         </div>
         <br /> 
         <div>
             
             <label for="username">Username:</label>
             <input type="text" id="username" name="username" required>
                 
         </div>
         <br /> 
         <div>
             

             <label for="password">Password:</label>
             <input type="password" id="password" name="password" required>
                 
         </div>
         <br /> 
         <div>
            <input type="submit" value="Sign up" />
        </div>
         <br /> 
     </form>
 </main>
 
</body>
</html>
