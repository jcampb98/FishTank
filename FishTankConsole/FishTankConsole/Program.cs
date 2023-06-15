// See https://aka.ms/new-console-template for more information
using FishTank;

var tank = new Tank();

var goldFish = new GoldFish("John");
var angelFish = new AngelFish("Robert");
var babelFish = new BabelFish("Peter");

tank.Add(goldFish);
Console.WriteLine(tank.Feed());

tank.Add(angelFish);
Console.WriteLine(tank.Feed());

tank.Add(babelFish);
Console.WriteLine(tank.Feed());
Console.ReadLine();
