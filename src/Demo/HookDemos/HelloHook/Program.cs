﻿using HarmonyLib;
using HookDemos.OwnerLibrary;
using System.Reflection;

Console.WriteLine("程序开始---------------------");

var student = new Student();
Console.WriteLine(student.GetDetails("沙漠尽头的狼"));     // 这里是还没有拦截之前的，正常输出：大家好，我是Dotnet9网站站长沙漠尽头的狼！

Console.WriteLine("注册拦截---------------------");

// 这里使用Harmony进行了整个程序集的拦截，即上面在拦截类上加了`HarmonyPatch`特性的类，在目标API调用时都会主动执行它里面的阅读方法，如：Prefix、Postfix
var harmony = new Harmony("com.dotnet9");
harmony.PatchAll(Assembly.GetExecutingAssembly());

Console.WriteLine("注册完成---------------------");

Console.WriteLine(student.GetDetails("沙漠之狐"));     // 注意和上面的代码对比，代码完全一样，但因为是在使用Harmony拦截后执行的，所以输出可能变了

Console.WriteLine("程序结束---------------------");
Console.ReadLine();