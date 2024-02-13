
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="WordVoyager.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

  
    <head>
      
    <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Home Page</title>
  <style>
    body {
      font-family: Arial, sans-serif;
      margin: 0;
      padding: 0;
      background-color: #f0f0f0;
    }
    .container {
      max-width: 800px;
      margin: 100px auto;
      text-align: center;
    }
    .btn {
      display: inline-block;
      padding: 10px 20px;
      margin: 10px;
      background-color: #007bff;
      color: #fff;
      text-decoration: none;
      border-radius: 5px;
      border: none;
      cursor: pointer;
      transition: background-color 0.3s ease;
    }
    .btn:hover {
      background-color: #0056b3;
    }
  </style>
</header>
<body>
    <header runat="server">
        </header>
  <div class="container">
    <h1>Welcome to WordVoyager!</h1>
    <p>Please log in or sign up to continue.</p>
    <a href="LoginPage.aspx" class="btn">Login</a>
    <a href="Signup.aspx" class="btn">Sign Up</a>
  </div>

</body>
</html>

  
   











