# NetCoreSample
Sample project using .Net core 3.1 and MVC template. Academic sample

We will using MVC and Web Api template to learn the base concepts about Net Core had been built. Moreover we will try to implement some razor views and html views searching compare the ways to create web applications. 

<h2>Frontend</h2>
<p>We'll use boopstrap 4 framework to build responsive views and vanilla Javascript to interact with DOM </p>
<p>To get base boopstrap template, please click <a href="https://getbootstrap.com/docs/4.5/getting-started/introduction/" target="_blank">Here.</a></p>

<h2>Backend</h2>
<p>We'll use dotnet core <b>3.1</b> to create different projects to match concepts between available projects on visual studio wizard. 
<br>
Moreover, we'll need a any database engine and we'll EntityFrameworkCore to improve our approach. 
<br>
<i>So, For this sample I will use <b>MySql</b></i> (Click to <a href="https://dev.mysql.com/downloads/installer/">Download</a>)
<br/>
Note: You can use wherever DB engine, feel like free!
</p>

<h4>Tools</h4>
<p>
<ul>
<li>Download Visual Studio 2019 <a href="https://visualstudio.microsoft.com/es/vs/community/" target="_blank">Here.</a></li>
<li>Download Visual Studio Code <a href="https://code.visualstudio.com/download" target="_blank">Here.</a></li>
  <li>Postman <a href="https://www.postman.com/downloads/" target="_blank">Here.</a></li>
</ul>
<br/>
<i><b>Remember:</b> You must install all dependencies for net core.<i/>
  Like this
</p>
<img src = "https://docs.microsoft.com/es-es/dotnet/core/install/media/install-sdk/windows-install-visual-studio-2019.png#lightbox" />

<h3>Scheduler Class</h3>
<p>
<ol>
  <li>Create a dot net core 3.1 project using visual studio 2019</li>
  <li>How To build a project on VS</li>
  <li>EntityFrameworCore (Code first approach)</li>
  <li>To be continue...</li>
</ol>
</p>

<h3>Db Diagram</h3>

![test2](https://user-images.githubusercontent.com/42014718/87883829-b3ca1500-c9cf-11ea-9206-22c55c201f4f.png)


<h4>Tips</h4>
<ul>
  <li><b>Nuget dependencies:</b> 
    <ul>
    <li>Microsoft.EntityFrameworkCore</li>
      <li>Microsoft.EntityFrameworkCore.Tools</li>
      <li>MySql.Data.EntityFrameworkCore</li>
      <li>Microsoft.EntityFrameworkCore.SqlServer</li>
      <li>Microsoft.AspNetCore.Mvc.NewtonsoftJson</li>
    </ul>
  </li>
  <li><b>Connection String:</b>   "ConnectionStrings": { "DefaultConnection": "server=localhost;port=3306;user=root;password=Diego1.;database=net_core_sample"}</li>
  <li><b>Add Context:</b>
    services.AddDbContext<inventekContext>(options =>
                options.UseMySQL(this.Configuration.GetConnectionString("DefaultConnection")));
  </li>
  <li><b>Resolve Json Responses:</b>
    services.AddMvc()
                .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver())
                .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore)
                .AddNewtonsoftJson(options => options.SerializerSettings.DateFormatHandling = DateFormatHandling.MicrosoftDateFormat)
                .AddNewtonsoftJson(options => options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc);
  
  </li>
  <li>
  Nuget Manage Console:
  <ul>
    <li>Fist Time --> Add-Migration Initial</li>
    <li>Update Database --> Update-Database (Update last Migration)</li>
   <li>More times --> Add-Migration [PutHereChangeName]</li>
    <li>Drop Database --> Drop-Database</li>
    <li>Remove last Migration --> Remove-Migration</li>
  </ul>
  </li>
</ul>




<p>Many thanks 
  <br>
  <b>Just do it!</b> - <i>Enjoy the play!</i>
</p>
